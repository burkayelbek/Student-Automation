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
using Veritabani.Model;

namespace frmGiris
{
    public partial class frmAddLecturer : Form
    {
        public frmAddLecturer()
        {
            InitializeComponent();
        }

        int gelenLecId;

        #region Akademisyenleri Listele
        private void SourceRefresh()
        {
            StudentDb stdDb = new StudentDb();
            List<Lecturer> stdList = new List<Lecturer>();
            stdList = stdDb.GetAllLecturer();
            dataGridView1.DataSource = stdList;
            dataGridView1.Columns[1].HeaderText = "Adı";
            dataGridView1.Columns[2].HeaderText = "Soyadı";
            dataGridView1.Columns[3].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[4].HeaderText = "Şifre";
        }
        #endregion 

        private void frmAkademisyenEkle_Load(object sender, EventArgs e)
        {
            
            SourceRefresh();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void frmAkademisyenEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer()
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                LoginType = 1

            };
            StudentDb stdb = new StudentDb();

            stdb.InsertLecturer(lecturer);
            txtName.Text = txtSurname.Text = txtUsername.Text = txtPassword.Text = string.Empty;

            SourceRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StudentDb stdDb = new StudentDb();
            bool result = stdDb.DeleteLecturer(gelenLecId);
            if (result == true)
            {
                MessageBox.Show(null, "Lecturer deleted successfully", "Delete Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = txtSurname.Text = txtUsername.Text = txtPassword.Text = string.Empty;
                SourceRefresh();
            }
            else
            {
                MessageBox.Show(null, "Lecturer cannot deleted", "Delete Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Lecturer newLecture = new Lecturer()
            {
                Id = gelenLecId,
                Name = txtName.Text,
                Surname = txtSurname.Text,

                Username = txtUsername.Text,
                Password = txtPassword.Text,

            };
            StudentDb stdDb = new StudentDb();
            stdDb.UpdateLecturerById(newLecture);

            txtName.Text = txtSurname.Text = txtUsername.Text = txtPassword.Text = string.Empty;

            SourceRefresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lecId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            gelenLecId = lecId;

            StudentDb stdDb = new StudentDb();
            Lecturer gelenAkademisyen = stdDb.GetLecturerById(lecId);

            txtName.Text = gelenAkademisyen.Name;
            txtSurname.Text = gelenAkademisyen.Surname;
            txtUsername.Text = gelenAkademisyen.Username;
            txtPassword.Text = gelenAkademisyen.Password;
        }
    }
}
