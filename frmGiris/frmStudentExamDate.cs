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
    public partial class frmStudentExamDate : Form
    {
        public frmStudentExamDate()
        {
            InitializeComponent();
        }
        StudentDb stdb = new StudentDb();
        int LessonId;
        private void frmOgrenciSinavTarihi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStudentOperations ogrenciIslemleri = new frmStudentOperations();
            ogrenciIslemleri.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentOperations ogrenciIslemleri = new frmStudentOperations();
            ogrenciIslemleri.Show();
        }

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
        private void frmOgrenciSinavTarihi_Load(object sender, EventArgs e)
        {
            sinavTarihleriniGoster();
        }
    }
}
