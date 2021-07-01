using DAL.Model;
using OgrenciOtomasyon.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmGiris
{
    public partial class frmLecturerStudentOperations : Form
    {
        public frmLecturerStudentOperations()
        {
            InitializeComponent();
        }

        int gelenOgrenciID;

        #region Öğrencileri Listele
        private void SourceRefresh()
        {
            StudentDb stdDb = new StudentDb();
            List<Student> stdList = new List<Student>();
            stdList = stdDb.GetAllStudents();
            dataGridView1.DataSource = stdList;
            dataGridView1.Columns[1].HeaderText = "Adı";
            dataGridView1.Columns[2].HeaderText = "Soyadı";
            dataGridView1.Columns[3].HeaderText = "Departman";
            dataGridView1.Columns[4].HeaderText = "Okul Numarası";
            dataGridView1.Columns[5].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[6].HeaderText = "Şifre";
            dataGridView1.Columns[7].HeaderText = "Yetki Tipi";
        }
        #endregion


        private void frmOgrenciIslemleri_Load(object sender, EventArgs e)
        {
            cmbDepartment.Items.Add("Bilgisayar Programcılığı");
            cmbDepartment.Items.Add("Sivil Havacılık");
            cmbDepartment.Items.Add("Hukuk");
            cmbDepartment.Items.Add("İşletme");
            cmbDepartment.Items.Add("Tıp");
            cmbDepartment.Items.Add("Diş Hekimliği");
            SourceRefresh();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

 

    

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void frmAkademisyenOgrenciIslemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Department = cmbDepartment.SelectedItem.ToString(),
                StudentIdNumber = txtStudentIdNumber.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                LoginType = 0

            };
            StudentDb stdb = new StudentDb();

            stdb.InsertStudent(student);
            txtName.Text = txtSurname.Text = txtStudentIdNumber.Text = txtUsername.Text = txtPassword.Text = string.Empty;
            cmbDepartment.Text = string.Empty;

            SourceRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StudentDb stdDb = new StudentDb();
            bool result = stdDb.DeleteStudent(gelenOgrenciID);
            if (result == true)
            {
                MessageBox.Show(null, "Student successfully deleted", "DELETE STUDENT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = txtSurname.Text = txtStudentIdNumber.Text = txtUsername.Text = txtPassword.Text = string.Empty;
                cmbDepartment.Text = "";
                SourceRefresh();
            }
            else
            {
                MessageBox.Show(null, "Student cannot deleted", "DELETE STUDENT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student()
            {
                Id = gelenOgrenciID,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                StudentIdNumber = txtStudentIdNumber.Text,
                Department = cmbDepartment.SelectedItem.ToString(),
                Username = txtUsername.Text,
                Password = txtPassword.Text,

            };
            StudentDb stdDb = new StudentDb();
            stdDb.UpdateStudentById(newStudent);

            txtName.Text = txtSurname.Text = txtStudentIdNumber.Text = txtUsername.Text = txtPassword.Text = string.Empty;
            cmbDepartment.Text = string.Empty;
            SourceRefresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ogrId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            gelenOgrenciID = ogrId;

            StudentDb stdDb = new StudentDb();
            Student gelenOgrenci = stdDb.GetStudentById(ogrId);

            txtName.Text = gelenOgrenci.Name;
            txtSurname.Text = gelenOgrenci.Surname;
            txtStudentIdNumber.Text = gelenOgrenci.StudentIdNumber;
            cmbDepartment.SelectedItem = gelenOgrenci.Department;
            txtUsername.Text = gelenOgrenci.Username;
            txtPassword.Text = gelenOgrenci.Password;
        }
    }
}
