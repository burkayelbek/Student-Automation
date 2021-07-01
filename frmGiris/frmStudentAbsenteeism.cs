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
using Veritabani.Actions;
using Veritabani.Model;

namespace frmGiris
{
    public partial class frmStudentAbsenteeism : Form
    {
        StudentDb std = new StudentDb();
        public frmStudentAbsenteeism()
        {
            InitializeComponent();
        }

        private void frmOgrenciIslemler_Load(object sender, EventArgs e)
        {
            Student loginStudent = std.GetStudentById(GetStudentId.StudentId);
            lblNameSurname.Text = loginStudent.Name + " " + loginStudent.Surname;

            List<Absenteeism> AbsenteeismList = std.GetAbsenteeismByStudentId(GetStudentId.StudentId);
            foreach (Absenteeism dayOfAbse in AbsenteeismList)
            {
                lBoxDevamsizliklar.Items.Add(dayOfAbse);
                lBoxDevamsizliklar.DisplayMember = "DayOfAbsenteeism";
            }

            lblToplamGun.Text = std.GetAbsenteeismTotalDayNumber(GetStudentId.StudentId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentOperations ogrenciIslem = new frmStudentOperations();
            ogrenciIslem.Show();
            
        }

        private void frmOgrenciDevamsizlik_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmStudentOperations frmOgrenciIslem = new frmStudentOperations();
            frmOgrenciIslem.Show();
            
        }
    }
}
