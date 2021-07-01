namespace frmGiris
{
    partial class frmStudentAbsenteeism
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
            this.lblToplamGun = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lBoxDevamsizliklar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(287, 219);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 32);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblToplamGun
            // 
            this.lblToplamGun.AutoSize = true;
            this.lblToplamGun.Location = new System.Drawing.Point(69, 219);
            this.lblToplamGun.Name = "lblToplamGun";
            this.lblToplamGun.Size = new System.Drawing.Size(0, 13);
            this.lblToplamGun.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total : ";
            // 
            // lBoxDevamsizliklar
            // 
            this.lBoxDevamsizliklar.DisplayMember = "DayOfAbsenteeism";
            this.lBoxDevamsizliklar.FormattingEnabled = true;
            this.lBoxDevamsizliklar.Location = new System.Drawing.Point(12, 55);
            this.lBoxDevamsizliklar.Name = "lBoxDevamsizliklar";
            this.lBoxDevamsizliklar.Size = new System.Drawing.Size(351, 147);
            this.lBoxDevamsizliklar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Days of Absence";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(12, 9);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(35, 13);
            this.lblNameSurname.TabIndex = 6;
            this.lblNameSurname.Text = "label1";
            // 
            // frmStudentAbsenteeism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 262);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblToplamGun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lBoxDevamsizliklar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNameSurname);
            this.Name = "frmStudentAbsenteeism";
            this.Text = "Show Absenteeism";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOgrenciDevamsizlik_FormClosed);
            this.Load += new System.EventHandler(this.frmOgrenciIslemler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblToplamGun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBoxDevamsizliklar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameSurname;
    }
}