namespace frmGiris
{
    partial class frmLogin
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
            this.btnStudentOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLectureOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudentOpen
            // 
            this.btnStudentOpen.BackgroundImage = global::frmGiris.Properties.Resources.studentLogin1;
            this.btnStudentOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudentOpen.Location = new System.Drawing.Point(6, 42);
            this.btnStudentOpen.Name = "btnStudentOpen";
            this.btnStudentOpen.Size = new System.Drawing.Size(120, 135);
            this.btnStudentOpen.TabIndex = 11;
            this.btnStudentOpen.UseVisualStyleBackColor = true;
            this.btnStudentOpen.Click += new System.EventHandler(this.btnStudentOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLectureOpen);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 183);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lecturer Login";
            // 
            // btnLectureOpen
            // 
            this.btnLectureOpen.BackgroundImage = global::frmGiris.Properties.Resources.teacherLogin;
            this.btnLectureOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLectureOpen.Location = new System.Drawing.Point(6, 42);
            this.btnLectureOpen.Name = "btnLectureOpen";
            this.btnLectureOpen.Size = new System.Drawing.Size(120, 135);
            this.btnLectureOpen.TabIndex = 9;
            this.btnLectureOpen.UseVisualStyleBackColor = true;
            this.btnLectureOpen.Click += new System.EventHandler(this.btnLectureOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStudentOpen);
            this.groupBox2.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(160, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 183);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 205);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLogin";
            this.Text = "Student Automation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiris_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLectureOpen;
        private System.Windows.Forms.Button btnStudentOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

