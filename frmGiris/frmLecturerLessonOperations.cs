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
    public partial class frmLecturerLessonOperations : Form
    {
        public frmLecturerLessonOperations()
        {
            InitializeComponent();
        }
        StudentDb dbNew = new StudentDb();
        #region Dersleri Listele
        private void SourceRefresh()
        {
            StudentDb stdDb = new StudentDb();
            List<AddLessonToStudent> stdList = new List<AddLessonToStudent>();
            stdList = stdDb.GetAllLessonsAndStudents();
            dataGridView1.DataSource = stdList;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Ders Adı";
            dataGridView1.Columns[4].HeaderText = "Öğrenci Adı";
        }
        #endregion

        private void frmAkademisyenDersIslemleri_Load(object sender, EventArgs e)
        {
            SourceRefresh();
            cmbLesson.DataSource = dbNew.GetAllLessons();
            cmbLesson.DisplayMember = "LessonName";
            cmbLesson.ValueMember = "Id";

            cmbStudent.DataSource = dbNew.GetAllStudents();
            cmbStudent.DisplayMember = "StudentIdNumber";
            cmbStudent.ValueMember = "Id";

            dataGridView1.Columns[0].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void frmAkademisyenDersIslemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {//tamam şimdi sende hata veren kısım ne 
            AddLessonToStudent lssn = new AddLessonToStudent()
            {

                LessonID = Convert.ToInt32(cmbLesson.SelectedValue),
                StudentID = Convert.ToInt32(cmbStudent.SelectedValue)
            };
            StudentDb stdb = new StudentDb();

            stdb.InsertLesson(lssn);

            SourceRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            StudentDb stdDb = new StudentDb();
            bool result = stdDb.DeleteLesson(id);
            if (result == true)
            {
                MessageBox.Show(null, "Course successfully deleted", "DELETE LESSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Course cannot deleted", "DELETE LESSON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            SourceRefresh();
        }   
    }
}
