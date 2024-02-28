namespace Library
{
    internal static class Program
    {
       public static List<Books> bookstoborrowList = new List<Books>();

       public static List<Books> borrowedbookList = new List<Books>();

       public static List<Booklover> userList = new List<Booklover>();

       public static IDictionary<Books, Booklover> booksAndUsers = new Dictionary<Books, Booklover>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Books book1 = new Books
            {
                Title = "Harry Potter",
                Author = "J.K. Rowling",
                Btype = Books.booktype.scifi,
                Code = 1,
                Price = 19.95
            };
            Books book2 = new Books
            {
                Title = "Me before you",
                Author = "Joyo Moyes",
                Btype = Books.booktype.romance,
                Code = 2,
                Price = 24.99
            };
            Books book3 = new Books
            {
                Title = "Titanic",
                Author = "Filson Young",
                Btype = Books.booktype.romance,
                Code = 3,
                Price = 22
            };
            Books book4 = new Books
            {
                Title = "Twilight",
                Author = "Stephanie Meyer",
                Btype = Books.booktype.scifi,
                Code = 4,
                Price = 21.5
            };
            Books book5 = new Books
            {
                Title = "The fault in our stars",
                Author = "John Greeb",
                Btype = Books.booktype.romance,
                Code = 5,
                Price = 19.9
            };
            Books book6 = new Books
            {
                Title = "Game of thrones",
                Author = "Georges martin",
                Btype = Books.booktype.scifi,
                Code = 6,
                Price = 25
            };
            Books book7 = new Books
            {
                Title = "Le petit prince",
                Author = "Antoine de saint-exupery",
                Btype = Books.booktype.scifi,
                Code = 7,
                Price = 17
            };
            Books book8 = new Books
            {
                Title = "Rich dad poor dad",
                Author = "Robert kiyosaki",
                Btype = Books.booktype.action,
                Code = 8,
                Price = 25
            };
            bookstoborrowList.Add(book1);bookstoborrowList.Add(book2);bookstoborrowList.Add(book3);
            bookstoborrowList.Add(book4);bookstoborrowList.Add(book5);bookstoborrowList.Add(book6);
            bookstoborrowList.Add(book7);bookstoborrowList.Add(book8);


            void AddBook(Books book, Booklover user)
            {
                if (!booksAndUsers.ContainsKey(book))
                {
                    booksAndUsers.Add(book, user);
                }
            }

            Booklover GetUser(Books book)
            {
                if (booksAndUsers.ContainsKey(book))
                {
                    return booksAndUsers[book];
                }
                else
                {
                    return null;
                }
            }
            Books Bbook1 = new Books
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Btype = Books.booktype.scifi,
                Code = 9,
                Price = 16
            };
            Books Bbook2 = new Books
            {
                Title = "Anna Karenina",
                Author = "Leo Tolstoy",
                Btype = Books.booktype.romance,
                Code = 10,
                Price = 21
            };
            Books Bbook3 = new Books
            {
                Title = "Born a crime",
                Author = "Trevor Noah",
                Btype = Books.booktype.comedy,
                Code = 11,
                Price = 20.5
            };
            Books Bbook4 = new Books
            {
                Title = "The Light We Carry",
                Author = "Michelle Obama",
                Btype = Books.booktype.romance,
                Code = 12,
                Price = 27.9
            };
            Books Bbook5 = new Books
            {
                Title = "Ugly Love",
                Author = "Colleen Hoover",
                Btype = Books.booktype.romance,
                Code = 13,
                Price = 25.5
            };
            Books Bbook6 = new Books
            {
                Title = "Beloved",
                Author = "Toni Morrison",
                Btype = Books.booktype.romance,
                Code = 14,
                Price = 18.8
            };
            borrowedbookList.Add(Bbook1);borrowedbookList.Add(Bbook2); borrowedbookList.Add(Bbook3);
            borrowedbookList.Add(Bbook4); borrowedbookList.Add(Bbook5);borrowedbookList.Add(Bbook6);

            Booklover user1 = new Booklover
            {
                FirstName = "Elie",
                LastName = "Kiwan",
                Email = "eliekiwan@gmail.com",
                Password = "kiwan123"
            };
            Booklover user2 = new Booklover
            {
                FirstName = "Chantal",
                LastName = "Fayad",
                Email = "chantalfayad@gmail.com",
                Password = "fayad123"
            };
            Booklover user3 = new Booklover
            {
                FirstName = "Thea",
                LastName = "Kassouf",
                Email = "theakassouf@gmail.com",
                Password = "kassouf123"
            };
            Booklover user4 = new Booklover
            {
                FirstName = "Hiba",
                LastName = "Hakim",
                Email = "hibahakim@gmail.com",
                Password = "hakim123"
            };
            Booklover user5 = new Booklover
            {
                FirstName = "Joumana",
                LastName = "Haddad",
                Email = "joumanahaddad@gmail.com",
                Password = "haddad123"
            };
            Booklover user6 = new Booklover
            {
                FirstName = "Fadi",
                LastName = "Chamoun",
                Email = "fadichamoun@gmail.com",
                Password = "chamoun123"
            };
            userList.Add(user1); userList.Add(user2);userList.Add(user3); userList.Add(user4);
            userList.Add(user5); userList.Add(user6);
            AddBook(Bbook1, user1);
            AddBook(Bbook2, user2);
            AddBook(Bbook3, user3);
            AddBook(Bbook4, user4);
            AddBook(Bbook5, user5);
            AddBook(Bbook6, user6);

            string filePath1 = @"D:\University\semestre 5\OOP\projet\Emails.txt"; 

            using (StreamWriter writer = new StreamWriter(filePath1))
            {
                foreach (Booklover user in userList)
                {
                    writer.WriteLine(user.Email);
                }
            }
            string filePath2 = @"D:\University\semestre 5\OOP\projet\Passwords.txt";

            using (StreamWriter writer = new StreamWriter(filePath2))
            {
                foreach (Booklover user in userList)
                {
                    writer.WriteLine(user.Password);
                }
            }
            string filePath3 = @"D:\University\semestre 5\OOP\projet\Bookstoborrow.txt";

            using (StreamWriter writer = new StreamWriter(filePath3))
            {
                foreach (Books book in bookstoborrowList)
                {
                    writer.WriteLine(book.Title);
                }
            }
            string filePath4 = @"D:\University\semestre 5\OOP\projet\Borrowedbooks.txt";

            using (StreamWriter writer = new StreamWriter(filePath4))
            {
                foreach (Books book in borrowedbookList)
                {
                    writer.WriteLine(book.Title);
                }
            }

            Application.Run(new StartForm());

            
        }
    }
}