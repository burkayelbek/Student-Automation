namespace frmGiris
{
    partial class frmLecturerMainOperations
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExamDate = new System.Windows.Forms.Button();
            this.btnAbsenteeism = new System.Windows.Forms.Button();
            this.btnLecturerAdd = new System.Windows.Forms.Button();
            this.btnNoteAdd = new System.Windows.Forms.Button();
            this.btnLessonOperation = new System.Windows.Forms.Button();
            this.btnStudentOperation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(247, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 32);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "LOGOUT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExamDate
            // 
            this.btnExamDate.Location = new System.Drawing.Point(192, 68);
            this.btnExamDate.Name = "btnExamDate";
            this.btnExamDate.Size = new System.Drawing.Size(131, 50);
            this.btnExamDate.TabIndex = 13;
            this.btnExamDate.Text = "Add Common Exam Date";
            this.btnExamDate.UseVisualStyleBackColor = true;
            this.btnExamDate.Click += new System.EventHandler(this.btnExamDate_Click);
            // 
            // btnAbsenteeism
            // 
            this.btnAbsenteeism.Location = new System.Drawing.Point(12, 124);
            this.btnAbsenteeism.Name = "btnAbsenteeism";
            this.btnAbsenteeism.Size = new System.Drawing.Size(131, 50);
            this.btnAbsenteeism.TabIndex = 10;
            this.btnAbsenteeism.Text = "Student Absenteeism Operations";
            this.btnAbsenteeism.UseVisualStyleBackColor = true;
            this.btnAbsenteeism.Click += new System.EventHandler(this.btnAbsenteeism_Click);
            // 
            // btnLecturerAdd
            // 
            this.btnLecturerAdd.Location = new System.Drawing.Point(192, 12);
            this.btnLecturerAdd.Name = "btnLecturerAdd";
            this.btnLecturerAdd.Size = new System.Drawing.Size(131, 50);
            this.btnLecturerAdd.TabIndex = 12;
            this.btnLecturerAdd.Text = "Add Lecturer";
            this.btnLecturerAdd.UseVisualStyleBackColor = true;
            this.btnLecturerAdd.Click += new System.EventHandler(this.btnLecturerAdd_Click);
            // 
            // btnNoteAdd
            // 
            this.btnNoteAdd.Location = new System.Drawing.Point(12, 68);
            this.btnNoteAdd.Name = "btnNoteAdd";
            this.btnNoteAdd.Size = new System.Drawing.Size(131, 50);
            this.btnNoteAdd.TabIndex = 9;
            this.btnNoteAdd.Text = "Student Exam Operations";
            this.btnNoteAdd.UseVisualStyleBackColor = true;
            this.btnNoteAdd.Click += new System.EventHandler(this.btnNoteAdd_Click);
            // 
            // btnLessonOperation
            // 
            this.btnLessonOperation.Location = new System.Drawing.Point(12, 220);
            this.btnLessonOperation.Name = "btnLessonOperation";
            this.btnLessonOperation.Size = new System.Drawing.Size(131, 50);
            this.btnLessonOperation.TabIndex = 11;
            this.btnLessonOperation.Text = "Lesson Operations";
            this.btnLessonOperation.UseVisualStyleBackColor = true;
            this.btnLessonOperation.Click += new System.EventHandler(this.btnLessonOperation_Click);
            // 
            // btnStudentOperation
            // 
            this.btnStudentOperation.Location = new System.Drawing.Point(12, 12);
            this.btnStudentOperation.Name = "btnStudentOperation";
            this.btnStudentOperation.Size = new System.Drawing.Size(131, 50);
            this.btnStudentOperation.TabIndex = 8;
            this.btnStudentOperation.Text = "Student Operations";
            this.btnStudentOperation.UseVisualStyleBackColor = true;
            this.btnStudentOperation.Click += new System.EventHandler(this.btnStudentOperation_Click);
            // 
            // frmLecturerMainOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 278);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExamDate);
            this.Controls.Add(this.btnAbsenteeism);
            this.Controls.Add(this.btnLecturerAdd);
            this.Controls.Add(this.btnNoteAdd);
            this.Controls.Add(this.btnLessonOperation);
            this.Controls.Add(this.btnStudentOperation);
            this.Name = "frmLecturerMainOperations";
            this.Text = "Lecturer Operations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAkademisyenAnaIslemler_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExamDate;
        private System.Windows.Forms.Button btnAbsenteeism;
        private System.Windows.Forms.Button btnLecturerAdd;
        private System.Windows.Forms.Button btnNoteAdd;
        private System.Windows.Forms.Button btnLessonOperation;
        private System.Windows.Forms.Button btnStudentOperation;
    }
}