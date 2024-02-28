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
    public partial class NewUserForm : Form
    {

        public NewUserForm()
        {
            InitializeComponent();
        }

        private void btnBackNewtoSignup_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            listBoxBooks.DataSource = Program.bookstoborrowList;
            listBoxBooks.DisplayMember = "Title";
            listBoxBooks.ValueMember = "";

        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxBooks_DoubleClick(object sender, EventArgs e)
        {
            Books book = (Books)listBoxBooks.SelectedItem;
            string message = $"Title: {book.Title}\nAuthor: {book.Author}\nType: {book.Btype}\nCode: {book.Code}\nPrice: {book.Price:C2}";
            MessageBox.Show(message, "Book Properties", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private bool buttonClicked = false;

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            Books book = (Books)listBoxBooks.SelectedItem;

            if (buttonClicked)
            {
                MessageBox.Show("You already borrowed a book");
                return;
            }
            else
            {
                int index = Program.bookstoborrowList.IndexOf(book);

                // chil object mnel list
                if (index >= 0)
                {
                    Program.bookstoborrowList.RemoveAt(index);
                }
                // Update list of titles in file
                List<string> titles = Program.bookstoborrowList.Select(b => b.Title).ToList();
                string path = @"D:\University\semestre 5\OOP\projet\Bookstoborrow.txt";
                File.WriteAllLines(path, titles);

                MessageBox.Show("You borrowed " + book.Title);
                
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = Program.bookstoborrowList;
                listBoxBooks.DisplayMember = "Title";
                listBoxBooks.ValueMember = "";
                buttonClicked = true;
            }
            Program.borrowedbookList.Add(book);
            List<string> titles1 = Program.borrowedbookList.Select(b => b.Title).ToList();
            string path2 = @"D:\University\semestre 5\OOP\projet\Borrowedbooks.txt";
            File.WriteAllLines(path2, titles1);

            string filePath = @"D:\University\semestre 5\OOP\projet\Info.txt";

            string[] lines = File.ReadAllLines(filePath);
            Booklover booklover = new Booklover
            {
                FirstName = lines[0],
                LastName = lines[1],
                Email = lines[2],
                Password = lines[3]
            };
            Program.booksAndUsers.Add(book, booklover);
            File.WriteAllText(filePath, string.Empty);

        }
 
    }


}
