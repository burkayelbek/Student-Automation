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
    public partial class frmStudentOperations : Form
    {
        public frmStudentOperations()
        {
            InitializeComponent();
        }

        private void btnDevamsizlikGoruntule_Click(object sender, EventArgs e)
        {
            frmStudentAbsenteeism openfrmOgrenciIslemler = new frmStudentAbsenteeism();
            openfrmOgrenciIslemler.Show();
            this.Hide();
        }

        private void frmOgrenciIslemler_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Response;

            Response = MessageBox.Show("Are You Sure You Want To Quit?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Response == DialogResult.Yes)
            {

                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;

            }
        }

        private void btnShowNotes_Click(object sender, EventArgs e)
        {
            frmStudentShowExamResults notGoruntule = new frmStudentShowExamResults();
            notGoruntule.Show();
            this.Hide();
        }

        private void btnExamDates_Click(object sender, EventArgs e)
        {
            frmStudentExamDate sinavTarihiGoruntule = new frmStudentExamDate();
            sinavTarihiGoruntule.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Response = new DialogResult();

            Response = MessageBox.Show("Are You Sure You Want To Quit?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Response == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (Response == DialogResult.No)
            {
                this.Show();

            }
        }
    }
}
