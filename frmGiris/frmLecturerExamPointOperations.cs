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
using Veritabani.Model;

namespace frmGiris
{
    public partial class frmLecturerExamPointOperations : Form
    {
        StudentDb stdb = new StudentDb();
        int LessonId, StudentId;
        public frmLecturerExamPointOperations()
        {
            InitializeComponent();
        }


        private void frmAkademisyenNotIslemleri_Load(object sender, EventArgs e)
        {
            cmbLesson.DataSource = stdb.GetAllLessons();
            cmbLesson.DisplayMember = "LessonName";
            cmbLesson.ValueMember = "Id";

            cmbStudent.DataSource = stdb.GetAllStudents();
            cmbStudent.DisplayMember = "StudentIdNumber";
            cmbStudent.ValueMember = "Id";
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentId = int.Parse(cmbStudent.SelectedValue.ToString());

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void frmAkademisyenNotIslemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtVisa.Text != "" && txtFinal.Text != "" && txtHomework.Text != "")
            {
                if (int.Parse(txtVisa.Text) <= 100 && int.Parse(txtFinal.Text) <= 100 && int.Parse(txtHomework.Text) <= 100)
                {
                    ExamOperation newEO = new ExamOperation()
                    {
                        Exam1 = int.Parse(txtVisa.Text),
                        Exam2 = int.Parse(txtFinal.Text),
                        Homework = int.Parse(txtHomework.Text),
                        LessonId = LessonId,
                        StudentId = StudentId
                    };
                    stdb.AddNote(newEO);
                    txtVisa.Text = txtFinal.Text = txtHomework.Text = string.Empty;
                    MessageBox.Show("ÖThe grades of the student have been added to the system!");
                }
                else
                {
                    MessageBox.Show("Entered grades must be less than 100!");
                }
                
            }

               
            else
            {
                MessageBox.Show("Please do not leave blank space!");
            }
        }

        private void cmbStudent_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            StudentId = int.Parse(cmbStudent.SelectedValue.ToString());
        }

        private void cmbLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            LessonId = int.Parse(cmbLesson.SelectedValue.ToString());
        }
    }
}

