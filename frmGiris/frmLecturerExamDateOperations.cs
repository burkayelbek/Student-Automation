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
using Veritabani.Actions;
using Veritabani.Model;

namespace frmGiris
{
    public partial class frmLecturerExamDateOperations : Form
    {
        public frmLecturerExamDateOperations()
        {
            InitializeComponent();
        }

        StudentDb stdb = new StudentDb();
        int LessonId;


        private void sinavTarihleriniGoster()
        {

            listView1.Items.Clear();
            listView1.View = View.Details;
            List<RepoLessonExamDate> examList = stdb.GetAllExams();
            foreach (RepoLessonExamDate ed in examList)
            {
                string[] str = new string[2];
                str[0] = ed.LesName;
                str[1] = ed.ExDate.ToShortDateString();
                ListViewItem lvi = new ListViewItem(str);
                listView1.Items.Add(lvi);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void frmAkademisyenSinavTarihleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void frmAkademisyenSinavTarihleri_Load(object sender, EventArgs e)
        {
            sinavTarihleriniGoster();

            cmbLesson.DataSource = stdb.GetAllLessons();
            cmbLesson.DisplayMember = "LessonName";
            cmbLesson.ValueMember = "Id";

        }

        private void cmbLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            LessonId = int.Parse(cmbLesson.SelectedValue.ToString());
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            ExaminationDate examDates = new ExaminationDate()
            {
                LessonId = LessonId,
                ExamDate = dateTimePicker1.Value.Date
            };
            stdb.AddExamDate(examDates);
            cmbLesson.Text = "";
            MessageBox.Show("The exam schedule for this course has been added to the system!");
            sinavTarihleriniGoster();
        }
    }
}
