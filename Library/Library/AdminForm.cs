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
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnBackAdmintoStart_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_title.Text))
                {
                    throw new Exception("The title cannot be empty!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_author.Text))
                {
                    throw new Exception("The author cannot be empty!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_price.Text))
                {
                    throw new Exception("The price cannot be empty!");
                }
                else if (string.IsNullOrWhiteSpace(textBox_code.Text))
                {
                    throw new Exception("The code cannot be empty!");
                }
                else if (string.IsNullOrWhiteSpace(comboBox_type.Text))
                {
                    throw new Exception("The type cannot be empty!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Books book = new Books
            {
                Title = textBox_title.Text,
                Author = textBox_author.Text,
                Btype = (Books.booktype)Enum.Parse(typeof(Books.booktype), comboBox_type.Text)
            };
            try
            {
                double price;
                if (double.TryParse(textBox_price.Text, out price))
                {
                    book.Price = double.Parse(textBox_price.Text);
                }
                else
                {
                   
                    MessageBox.Show("The price must be a double!");
                    return;
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                int code;
                if (int.TryParse(textBox_code.Text, out code))
                {
                    bool exists = Program.bookstoborrowList.Any(b => b.Code == code);
                    if (exists)
                    {
                        MessageBox.Show("The book code is already in use!");
                        return;
                    }
                    else
                    {
                        book.Code = int.Parse(textBox_code.Text);
                    }
                }
                else
                {

                    MessageBox.Show("The code must be an integer!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Program.bookstoborrowList.Add(book);
            string path = @"D:\University\semestre 5\OOP\projet\Bookstoborrow.txt";
            File.AppendAllLines(path, new[] { book.Title });
            MessageBox.Show("The new book titled" + " '"+ book.Title +"' "+ "was added to the Library");

        }

        private void btnShowBooksAdmin_Click(object sender, EventArgs e)
        {

            listBox_booksadmin.DataSource = Program.bookstoborrowList;
            listBox_booksadmin.DisplayMember = "";
            listBox_booksadmin.ValueMember = "";
            //3melet override la Tostring la tbayenle title w price fa hattet "" lal display w member
        }

        private void listBox_booksadmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {

            listBox_users.Items.Clear();

            foreach (KeyValuePair<Books, Booklover> kvp in Program.booksAndUsers)
            {
                listBox_users.Items.Add($"{kvp.Key.Title} : {kvp.Value}");
            }


        }

        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            Books[] books = new Books[listBox_booksadmin.Items.Count];
            int i = 0;
            foreach (Books book in listBox_booksadmin.Items)
            {
                books[i] = book;
                i++;
            }
            Array.Sort(books, new BookPriceComparer());
            listBox_booksadmin.DataSource = books;


        }
        public static string Read(string filePath)
        {
            StreamReader oStreamReader;
            string fileText;

            try
            {
                oStreamReader = File.OpenText(filePath);
                fileText = oStreamReader.ReadToEnd();
                oStreamReader.Close();
                return fileText;
            }
            catch (FileNotFoundException ex)
            {
                return ex.Message;
            }
            catch (IOException ex)
            {
                return ex.Message;
            }
            finally
            {
                Thread.Sleep(5000);
            }
        }

        private static void Show()
        {
            //Thread.Sleep(500);
            string path = @"D:\University\semestre 5\OOP\projet\Emails.txt";
            MessageBox.Show(Read(path));
        }
        private async void btnAsyncShowEmails_Click(object sender, EventArgs e)
        {
            await Task.Run(new Action(Show));
        }
    }
}
