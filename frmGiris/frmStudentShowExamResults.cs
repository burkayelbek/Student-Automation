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
    public partial class frmStudentShowExamResults : Form
    {
        StudentDb stddb = new StudentDb();
        public frmStudentShowExamResults()
        {
            InitializeComponent();
        }

        private void frmOgrenciNotGoruntuleme_FormClosed(object sender, FormClosedEventArgs e)
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

        private void frmOgrenciNotGoruntuleme_Load(object sender, EventArgs e)
        {
            dgvNotlar.DataSource = stddb.GetNotesByStudentId(GetStudentId.StudentId);
            
        }
    }
}
