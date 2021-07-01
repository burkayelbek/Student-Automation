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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLectureOpen_Click(object sender, EventArgs e)
        {
            frmLecturerLogin openfrmAkademisyenGiris = new frmLecturerLogin();
            openfrmAkademisyenGiris.Show();
            this.Hide();
        }

        private void btnStudentOpen_Click(object sender, EventArgs e)
        {
            frmStudentLogin openfrmOgrenciGiris = new frmStudentLogin();
            openfrmOgrenciGiris.Show();
            this.Hide();
        }

        private void frmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Response;

            Response = MessageBox.Show("Are You Sure You Want To Quit?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Response == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;

            }
        }
    }
}
