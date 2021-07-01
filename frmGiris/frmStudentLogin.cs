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

namespace frmGiris
{
    public partial class frmStudentLogin : Form
    {
        public frmStudentLogin()
        {
            InitializeComponent();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            StudentDb stdb = new StudentDb();
            Student loginStudent = stdb.GetStudentLogin(txtUsername.Text, txtPassword.Text);
            if (loginStudent!=null)
            {
                GetStudentId.StudentId = loginStudent.Id;
                frmStudentOperations openfrmOgrenciIslemler = new frmStudentOperations();
                openfrmOgrenciIslemler.Show();
                this.Hide();
            }
            else
            {
                lblStudentResult.Text = "Username or password are incorrect!";
            }
        }

        private void frmOgrenciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frmGirisAc = new frmLogin();
            frmGirisAc.Show();
            this.Hide();
        }
    }
}
