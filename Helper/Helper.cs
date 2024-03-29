﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Helper
{
    public class Helper
    {
        private Panel panel;
        public Helper(Panel _panel)
        {
            this.panel = _panel;
        }
        public void formGoster(Form form, string formName)
        {
            panel.Controls.Clear();
            if (form != null)
            {
                switch (formName)
                {
                    case "MainLoginButtons":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "PatientLoginGUI":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "DoctorLoginGUI":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "SecretaryLoginGUI":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "AdminLoginGUI":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    case "PatientSignUpGUI":
                        form.TopLevel = false;
                        form.AutoScroll = true;
                        form.Dock = DockStyle.None;
                        form.Location = new Point(1, 56);
                        panel.Controls.Add(form);
                        form.Show();
                        break;
                    default:
                        panel.Controls.Clear();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Sayfa bulunamadi.");
            }
        }
    }
}
