﻿namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class PatientALF
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
            panel1 = new Panel();
            buttonPALF_Bilgilerim = new Button();
            buttonPALF_RandevuBilgileri = new Button();
            buttonPALF_RandevuAl = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelDALF_DoctorID = new Label();
            labelPALF_Hg = new Label();
            panelPatientALF = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(buttonPALF_Bilgilerim);
            panel1.Controls.Add(buttonPALF_RandevuBilgileri);
            panel1.Controls.Add(buttonPALF_RandevuAl);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 536);
            panel1.TabIndex = 0;
            // 
            // buttonPALF_Bilgilerim
            // 
            buttonPALF_Bilgilerim.Dock = DockStyle.Top;
            buttonPALF_Bilgilerim.Font = new Font("Yu Gothic UI Semibold", 12F);
            buttonPALF_Bilgilerim.Location = new Point(0, 317);
            buttonPALF_Bilgilerim.Margin = new Padding(3, 4, 3, 4);
            buttonPALF_Bilgilerim.Name = "buttonPALF_Bilgilerim";
            buttonPALF_Bilgilerim.Size = new Size(286, 80);
            buttonPALF_Bilgilerim.TabIndex = 3;
            buttonPALF_Bilgilerim.Text = "Bilgilerim";
            buttonPALF_Bilgilerim.UseVisualStyleBackColor = true;
            buttonPALF_Bilgilerim.Click += buttonPALF_Bilgilerim_Click;
            // 
            // buttonPALF_RandevuBilgileri
            // 
            buttonPALF_RandevuBilgileri.Dock = DockStyle.Top;
            buttonPALF_RandevuBilgileri.Font = new Font("Yu Gothic UI Semibold", 12F);
            buttonPALF_RandevuBilgileri.Location = new Point(0, 237);
            buttonPALF_RandevuBilgileri.Margin = new Padding(3, 4, 3, 4);
            buttonPALF_RandevuBilgileri.Name = "buttonPALF_RandevuBilgileri";
            buttonPALF_RandevuBilgileri.Size = new Size(286, 80);
            buttonPALF_RandevuBilgileri.TabIndex = 2;
            buttonPALF_RandevuBilgileri.Text = "Randevu Bilgileri";
            buttonPALF_RandevuBilgileri.UseVisualStyleBackColor = true;
            buttonPALF_RandevuBilgileri.Click += buttonPALF_RandevuBilgileri_Click;
            // 
            // buttonPALF_RandevuAl
            // 
            buttonPALF_RandevuAl.Dock = DockStyle.Top;
            buttonPALF_RandevuAl.Font = new Font("Yu Gothic UI Semibold", 12F);
            buttonPALF_RandevuAl.Location = new Point(0, 157);
            buttonPALF_RandevuAl.Margin = new Padding(3, 4, 3, 4);
            buttonPALF_RandevuAl.Name = "buttonPALF_RandevuAl";
            buttonPALF_RandevuAl.Size = new Size(286, 80);
            buttonPALF_RandevuAl.TabIndex = 1;
            buttonPALF_RandevuAl.Text = "Randevu Al";
            buttonPALF_RandevuAl.UseVisualStyleBackColor = true;
            buttonPALF_RandevuAl.Click += buttonPALF_RandevuAl_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(labelDALF_DoctorID);
            panel2.Controls.Add(labelPALF_Hg);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 157);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Salmon;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F);
            label3.Location = new Point(133, 104);
            label3.Name = "label3";
            label3.Size = new Size(46, 23);
            label3.TabIndex = 46;
            label3.Text = "label";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Salmon;
            label2.Font = new Font("Yu Gothic UI Semibold", 10F);
            label2.Location = new Point(111, 64);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 45;
            label2.Text = "label";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Salmon;
            label1.Font = new Font("Yu Gothic UI Semibold", 10F);
            label1.Location = new Point(12, 104);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 44;
            label1.Text = "Patient Name=";
            // 
            // labelDALF_DoctorID
            // 
            labelDALF_DoctorID.AutoSize = true;
            labelDALF_DoctorID.BackColor = Color.Salmon;
            labelDALF_DoctorID.Font = new Font("Yu Gothic UI Semibold", 10F);
            labelDALF_DoctorID.Location = new Point(12, 64);
            labelDALF_DoctorID.Name = "labelDALF_DoctorID";
            labelDALF_DoctorID.Size = new Size(103, 23);
            labelDALF_DoctorID.TabIndex = 43;
            labelDALF_DoctorID.Text = "Patient ID =";
            // 
            // labelPALF_Hg
            // 
            labelPALF_Hg.AutoSize = true;
            labelPALF_Hg.Font = new Font("Yu Gothic UI Semibold", 15F);
            labelPALF_Hg.Location = new Point(62, 19);
            labelPALF_Hg.Name = "labelPALF_Hg";
            labelPALF_Hg.Size = new Size(150, 35);
            labelPALF_Hg.TabIndex = 0;
            labelPALF_Hg.Text = "Hosgeldiniz";
            // 
            // panelPatientALF
            // 
            panelPatientALF.BackColor = Color.White;
            panelPatientALF.Dock = DockStyle.Fill;
            panelPatientALF.Location = new Point(286, 0);
            panelPatientALF.Margin = new Padding(3, 4, 3, 4);
            panelPatientALF.Name = "panelPatientALF";
            panelPatientALF.Size = new Size(687, 536);
            panelPatientALF.TabIndex = 1;
            // 
            // PatientALF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(973, 536);
            Controls.Add(panelPatientALF);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientALF";
            Text = "PatientALF";
            FormClosed += PatientALF_FormClosed;
            Load += PatientALF_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button buttonPALF_RandevuAl;
        private Button buttonPALF_Bilgilerim;
        private Button buttonPALF_RandevuBilgileri;
        private Label labelPALF_Hg;
        private Panel panelPatientALF;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelDALF_DoctorID;
    }
}