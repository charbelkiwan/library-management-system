namespace Library
{
    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
           SignUpForm signupForm = new SignUpForm();
           signupForm.Show();
           this.Hide();
        }

    

        private void  btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_email.Text))
                {
                    throw new Exception("Email cannot be empty!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_password.Text))
                {
                    throw new Exception("Password cannot be empty!");
                }
             }           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Books oBooks = new Books();
            oBooks.LoginEvent2 += new LoginEventHandler(LoginEventFunction2); //bifarjine chou lbook
            oBooks.LoginEvent1 += new LoginEventHandler(LoginEventFunction1); //login bfout aal admin form
            oBooks.Login(textBox_email.Text, textBox_password.Text);

            
        }

        void LoginEventFunction1(string loginEmail, string password)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }
        void LoginEventFunction2(string loginEmail, string password)
        {
            string filepath1 = @"D:\University\semestre 5\OOP\projet\Emails.txt";
            string filepath2 = @"D:\University\semestre 5\OOP\projet\Passwords.txt";
            

            using (StreamReader emailReader = new StreamReader(filepath1))
            using (StreamReader passwordReader = new StreamReader(filepath2))
            {        
                string emailLine;
                string passwordLine;
                     while ((emailLine = emailReader.ReadLine()) != null && (passwordLine = passwordReader.ReadLine()) != null)
                     {   
                        if (string.Equals(loginEmail, emailLine, StringComparison.OrdinalIgnoreCase) && string.Equals(password, passwordLine, StringComparison.Ordinal))
                        {
                            Booklover booklover = Program.booksAndUsers.Where(x => x.Value.Email == loginEmail).Select(x => x.Value).FirstOrDefault();
                            Books book = Program.booksAndUsers.FirstOrDefault(x => x.Value == booklover).Key;
                            MessageBox.Show("Hello "+ booklover.FirstName +  " your book is "  + "'"+ book.Title +"'");

                            return;
                        }
                     }   
            }        
                            MessageBox.Show("Login failed");
            
           
        }

    }
}