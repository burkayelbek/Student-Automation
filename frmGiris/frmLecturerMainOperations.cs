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
    public partial class frmLecturerMainOperations : Form
    {
        public frmLecturerMainOperations()
        {
            InitializeComponent();
        }


        private void btnAddNotices_Click(object sender, EventArgs e)
        {
            frmLecturerExamPointOperations akademisyenDuyuruIslemleri = new frmLecturerExamPointOperations();
            akademisyenDuyuruIslemleri.Show();
            this.Hide();
        }
       

        private void btnExamDate_Click(object sender, EventArgs e)
        {
            frmLecturerExamDateOperations sinavTarihi = new frmLecturerExamDateOperations();
            sinavTarihi.Show();
            this.Hide();
        }

        private void btnNoteAdd_Click(object sender, EventArgs e)
        {
            frmLecturerExamPointOperations akademisyenDuyuruIslemleri = new frmLecturerExamPointOperations();
            akademisyenDuyuruIslemleri.Show();
            this.Hide();
        }

        private void btnStudentOperation_Click(object sender, EventArgs e)
        {
            frmLecturerStudentOperations akademisyenOgrenciIslemleri = new frmLecturerStudentOperations();
            akademisyenOgrenciIslemleri.Show();
            this.Hide();
        }

        private void btnAbsenteeism_Click(object sender, EventArgs e)
        {
            frmLecturerStudentAbsenteeism akademisyenOgrenciDevamsizlik = new frmLecturerStudentAbsenteeism();
            akademisyenOgrenciDevamsizlik.Show();
            this.Hide();
        }

        private void btnLecturerAdd_Click(object sender, EventArgs e)
        {
            frmAddLecturer akademisyenEkle = new frmAddLecturer();
            akademisyenEkle.Show();
            this.Hide();
        }

        private void btnLessonOperation_Click(object sender, EventArgs e)
        {
            frmLecturerLessonOperations akademisyenDersIslemleri = new frmLecturerLessonOperations();
            akademisyenDersIslemleri.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Response = new DialogResult();

            Response = MessageBox.Show("Are You Sure You Want To Quit", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Response == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (Response == DialogResult.No)
            {
                this.Show();

            }
        }

        private void frmAkademisyenAnaIslemler_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
