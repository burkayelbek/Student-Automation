namespace frmGiris
{
    partial class frmStudentOperations
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
            this.btnExamDates = new System.Windows.Forms.Button();
            this.btnShowNotes = new System.Windows.Forms.Button();
            this.btnDevamsizlikGoruntule = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExamDates
            // 
            this.btnExamDates.Location = new System.Drawing.Point(12, 58);
            this.btnExamDates.Name = "btnExamDates";
            this.btnExamDates.Size = new System.Drawing.Size(117, 40);
            this.btnExamDates.TabIndex = 5;
            this.btnExamDates.Text = "Exam Dates";
            this.btnExamDates.UseVisualStyleBackColor = true;
            this.btnExamDates.Click += new System.EventHandler(this.btnExamDates_Click);
            // 
            // btnShowNotes
            // 
            this.btnShowNotes.Location = new System.Drawing.Point(12, 12);
            this.btnShowNotes.Name = "btnShowNotes";
            this.btnShowNotes.Size = new System.Drawing.Size(117, 40);
            this.btnShowNotes.TabIndex = 4;
            this.btnShowNotes.Text = "Show Exam Results";
            this.btnShowNotes.UseVisualStyleBackColor = true;
            this.btnShowNotes.Click += new System.EventHandler(this.btnShowNotes_Click);
            // 
            // btnDevamsizlikGoruntule
            // 
            this.btnDevamsizlikGoruntule.Location = new System.Drawing.Point(12, 104);
            this.btnDevamsizlikGoruntule.Name = "btnDevamsizlikGoruntule";
            this.btnDevamsizlikGoruntule.Size = new System.Drawing.Size(117, 40);
            this.btnDevamsizlikGoruntule.TabIndex = 3;
            this.btnDevamsizlikGoruntule.Text = "Absenteeisms";
            this.btnDevamsizlikGoruntule.UseVisualStyleBackColor = true;
            this.btnDevamsizlikGoruntule.Click += new System.EventHandler(this.btnDevamsizlikGoruntule_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(202, 112);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 32);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "LOGOUT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStudentOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 150);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExamDates);
            this.Controls.Add(this.btnShowNotes);
            this.Controls.Add(this.btnDevamsizlikGoruntule);
            this.Name = "frmStudentOperations";
            this.Text = "Student Operations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOgrenciIslemler_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExamDates;
        private System.Windows.Forms.Button btnShowNotes;
        private System.Windows.Forms.Button btnDevamsizlikGoruntule;
        private System.Windows.Forms.Button btnExit;
    }
}