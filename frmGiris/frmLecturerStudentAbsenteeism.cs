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
    public partial class frmLecturerStudentAbsenteeism : Form
    {
        StudentDb stdbActions = new StudentDb();
        int StudentId;
        public frmLecturerStudentAbsenteeism()
        {
            InitializeComponent();
        }

        private void frmAkademisyenOgrenciDevamsizlik_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = stdbActions.GetAllStudents();
            comboBox1.DisplayMember = "StudentIdNumber";
            comboBox1.ValueMember = "Id";
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void frmAkademisyenOgrenciDevamsizlik_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLecturerMainOperations anaIslem = new frmLecturerMainOperations();
            anaIslem.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Absenteeism newAbsen = new Absenteeism()
            {
                StudentId = StudentId,
                DayOfAbsenteeism = dateTimePicker1.Value.Date
            };
            stdbActions.AddAbsenteeism(newAbsen);
            MessageBox.Show("Student absenteeism added successfully.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentId = int.Parse(comboBox1.SelectedValue.ToString());
        }
    }
}
