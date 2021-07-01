namespace frmGiris
{
    partial class frmLecturerExamPointOperations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHomework = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtVisa = new System.Windows.Forms.TextBox();
            this.cmbLesson = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(172, 186);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 32);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbStudent
            // 
            this.cmbStudent.DisplayMember = "StudentIdNumber";
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(100, 7);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(148, 21);
            this.cmbStudent.TabIndex = 25;
            this.cmbStudent.ValueMember = "Id";
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(236, 36);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Homework  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Final         :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Midterm    :";
            // 
            // txtHomework
            // 
            this.txtHomework.Location = new System.Drawing.Point(203, 83);
            this.txtHomework.Name = "txtHomework";
            this.txtHomework.Size = new System.Drawing.Size(34, 20);
            this.txtHomework.TabIndex = 20;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(74, 110);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(34, 20);
            this.txtFinal.TabIndex = 19;
            // 
            // txtVisa
            // 
            this.txtVisa.Location = new System.Drawing.Point(74, 84);
            this.txtVisa.Name = "txtVisa";
            this.txtVisa.Size = new System.Drawing.Size(34, 20);
            this.txtVisa.TabIndex = 18;
            // 
            // cmbLesson
            // 
            this.cmbLesson.DisplayMember = "LessonName";
            this.cmbLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLesson.FormattingEnabled = true;
            this.cmbLesson.Location = new System.Drawing.Point(101, 35);
            this.cmbLesson.Name = "cmbLesson";
            this.cmbLesson.Size = new System.Drawing.Size(147, 21);
            this.cmbLesson.TabIndex = 17;
            this.cmbLesson.ValueMember = "Id";
            this.cmbLesson.SelectedIndexChanged += new System.EventHandler(this.cmbLesson_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Choose Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Choose Lesson";
            // 
            // frmLecturerExamPointOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 230);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHomework);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVisa);
            this.Controls.Add(this.cmbLesson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLecturerExamPointOperations";
            this.Text = "Exam Result Operations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAkademisyenNotIslemleri_FormClosed);
            this.Load += new System.EventHandler(this.frmAkademisyenNotIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHomework;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtVisa;
        private System.Windows.Forms.ComboBox cmbLesson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}