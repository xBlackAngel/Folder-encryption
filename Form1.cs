using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (SimplaTextBox1.Text == "")
                    {
                        MessageBox.Show("حدد مسار المجلد", "تنبيه");
                    }
                    else
                    {
                        FileSystemSecurity fs = File.GetAccessControl(SimplaTextBox1.Text);
                        fs.AddAccessRule(new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny));
                        File.SetAccessControl(SimplaTextBox1.Text, (FileSecurity)fs);
                        MessageBox.Show("تم حماية المجلد ");
                        // Application.Exit()
                    }
                }
                catch (Exception ex)
                {
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (SimplaTextBox1.Text == "")
                    {
                        MessageBox.Show("حدد مسار المجلد");
                    }
                    else
                    {
                        FileSystemSecurity fs = File.GetAccessControl(SimplaTextBox1.Text);
                        fs.RemoveAccessRule(new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny));
                        File.SetAccessControl(SimplaTextBox1.Text, (FileSecurity)fs);
                        MessageBox.Show("تم الغاء الحمايه ");
                        // Application.Exit()
                    }
                }
                catch (Exception ex)
                {
                }
            }

        }
    }
}