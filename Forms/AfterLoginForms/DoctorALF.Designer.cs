﻿namespace HospitalManagementSystem.Forms.AfterLoginForms
{
    partial class DoctorALF
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
            label2 = new Label();
            label1 = new Label();
            labelDALF_DoctorID = new Label();
            labeDALF_DoctorName = new Label();
            buttonDALF_İnformation = new Button();
            buttonDALF_ViewAppointment = new Button();
            pictureBox1 = new PictureBox();
            panelDoctorALF = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelDALF_DoctorID);
            panel1.Controls.Add(labeDALF_DoctorName);
            panel1.Controls.Add(buttonDALF_İnformation);
            panel1.Controls.Add(buttonDALF_ViewAppointment);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 621);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(196, 98);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 44;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(196, 51);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 43;
            label1.Text = "label1";
            // 
            // labelDALF_DoctorID
            // 
            labelDALF_DoctorID.AutoSize = true;
            labelDALF_DoctorID.BackColor = Color.Salmon;
            labelDALF_DoctorID.Font = new Font("Yu Gothic UI Semibold", 10F);
            labelDALF_DoctorID.Location = new Point(60, 48);
            labelDALF_DoctorID.Name = "labelDALF_DoctorID";
            labelDALF_DoctorID.Size = new Size(101, 23);
            labelDALF_DoctorID.TabIndex = 42;
            labelDALF_DoctorID.Text = "Doctor ID =";
            // 
            // labeDALF_DoctorName
            // 
            labeDALF_DoctorName.AutoSize = true;
            labeDALF_DoctorName.Font = new Font("Yu Gothic UI Semibold", 10F);
            labeDALF_DoctorName.Location = new Point(60, 96);
            labeDALF_DoctorName.Name = "labeDALF_DoctorName";
            labeDALF_DoctorName.Size = new Size(130, 23);
            labeDALF_DoctorName.TabIndex = 1;
            labeDALF_DoctorName.Text = "Doctor Name =";
            // 
            // buttonDALF_İnformation
            // 
            buttonDALF_İnformation.Dock = DockStyle.Bottom;
            buttonDALF_İnformation.Location = new Point(0, 160);
            buttonDALF_İnformation.Name = "buttonDALF_İnformation";
            buttonDALF_İnformation.Size = new Size(338, 53);
            buttonDALF_İnformation.TabIndex = 7;
            buttonDALF_İnformation.Text = "İnformation";
            buttonDALF_İnformation.UseVisualStyleBackColor = true;
            buttonDALF_İnformation.Click += buttonDALF_İnformation_Click;
            // 
            // buttonDALF_ViewAppointment
            // 
            buttonDALF_ViewAppointment.Dock = DockStyle.Bottom;
            buttonDALF_ViewAppointment.Location = new Point(0, 213);
            buttonDALF_ViewAppointment.Name = "buttonDALF_ViewAppointment";
            buttonDALF_ViewAppointment.Size = new Size(338, 53);
            buttonDALF_ViewAppointment.TabIndex = 6;
            buttonDALF_ViewAppointment.Text = "View Appointment";
            buttonDALF_ViewAppointment.UseVisualStyleBackColor = true;
            buttonDALF_ViewAppointment.Click += buttonDALF_ViewAppointment_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.HospitalSystemLoginGUILogo;
            pictureBox1.Location = new Point(0, 266);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelDoctorALF
            // 
            panelDoctorALF.BackColor = Color.White;
            panelDoctorALF.Dock = DockStyle.Fill;
            panelDoctorALF.Location = new Point(338, 0);
            panelDoctorALF.Name = "panelDoctorALF";
            panelDoctorALF.Size = new Size(946, 621);
            panelDoctorALF.TabIndex = 1;
            // 
            // DoctorALF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 621);
            Controls.Add(panelDoctorALF);
            Controls.Add(panel1);
            Name = "DoctorALF";
            Text = "DoctorALF";
            FormClosed += DoctorALF_FormClosed;
            Load += DoctorALF_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonDALF_ViewAppointment;
        private Button button2;
        private Button buttonDALF_İnformation;
        private Label labeDALF_DoctorName;
        private Label labelDALF_DoctorID;
        private Panel panelDoctorALF;
        private Label label1;
        private Label label2;
    }
}