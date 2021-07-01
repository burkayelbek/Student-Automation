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
    public partial class frmLecturerLogin : Form
    {
        public frmLecturerLogin()
        {
            InitializeComponent();
        }

        private void btnLecturerLogin_Click(object sender, EventArgs e)
        {
            StudentDb std = new StudentDb();
            bool LoginProcess = std.GetLecturerLogin(txtUsername.Text, txtPassword.Text);
            if (LoginProcess == true)
            {
                frmLecturerMainOperations openfrmAkademisyen = new frmLecturerMainOperations();
                openfrmAkademisyen.Show();
                this.Hide();

            }
            else
            {
                lblLecturerResult.Text = "Username or password are incorrect";
            }
        }

        private void frmAkademisyenGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frmGirisAc = new frmLogin();
            frmGirisAc.Show();
            this.Hide();
        }
    }
}
