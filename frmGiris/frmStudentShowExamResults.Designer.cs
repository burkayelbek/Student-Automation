﻿namespace frmGiris
{
    partial class frmStudentShowExamResults
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvNotlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exam Results";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(612, 256);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 32);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvNotlar
            // 
            this.dgvNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotlar.Location = new System.Drawing.Point(13, 29);
            this.dgvNotlar.Name = "dgvNotlar";
            this.dgvNotlar.Size = new System.Drawing.Size(669, 221);
            this.dgvNotlar.TabIndex = 27;
            // 
            // frmStudentShowExamResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 292);
            this.Controls.Add(this.dgvNotlar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Name = "frmStudentShowExamResults";
            this.Text = "Show Exam Results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOgrenciNotGoruntuleme_FormClosed);
            this.Load += new System.EventHandler(this.frmOgrenciNotGoruntuleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvNotlar;
    }
}