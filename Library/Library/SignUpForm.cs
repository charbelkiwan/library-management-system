using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnbacktostart_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            bool anyEmpty = false;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox && IsTextBoxEmpty((TextBox)control))
                {
                    anyEmpty = true;
                    break;
                }
            }

            if (anyEmpty)
            {
                MessageBox.Show("One or more text boxes are empty!");
                return;
            }
            
            

            
            Booklover user = new Booklover();

            string password = textBox_passwordsignup.Text;

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long!");
                return;
            }
            else
            {
                user.Password = password;
            }

            user.FirstName = textBox_firstname.Text;
            user.LastName = textBox_lastname.Text;
            
            
            string filePath1 = @"D:\University\semestre 5\OOP\projet\Emails.txt";
            string email = textBox_emailsignup.Text;
            string[] lines1 = File.ReadAllLines(filePath1);

            if (Array.IndexOf(lines1, email) == -1)
            {
                File.AppendAllLines(filePath1, new string[] { email });

            }
            else
            {
                MessageBox.Show("Enter a different email");
                return;
            }
            user.Email = textBox_emailsignup.Text;
            Program.userList.Add(user);

            string filePath2 = @"D:\University\semestre 5\OOP\projet\Passwords.txt";
            string[] lines2 = File.ReadAllLines(filePath2);
            File.AppendAllLines(filePath2, new string[] { password });

            string filePath3 = @"D:\University\semestre 5\OOP\projet\Info.txt";

            using (StreamWriter writer = new StreamWriter(filePath3))
            {
                writer.WriteLine(textBox_firstname.Text);
                writer.WriteLine(textBox_lastname.Text);
                writer.WriteLine(textBox_emailsignup.Text);
                writer.WriteLine(textBox_passwordsignup.Text);
            }

            NewUserForm newUserForm = new NewUserForm();
            newUserForm.Show();
            this.Hide();
        }
        private bool IsTextBoxEmpty(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }
    }
   
}
