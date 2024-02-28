using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public delegate void LoginEventHandler(string email, string password);


    public class Books
    {
        public enum booktype
        {
            horror,
            romance,
            scifi,
            comedy,
            action

        }
        private string title="";
        private string author="";
        private double price;
        private int code;
        private booktype btype;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public booktype Btype
        {
            get { return btype; }
            set { btype = value; }
        }
        public event LoginEventHandler LoginEvent1;
        public event LoginEventHandler LoginEvent2;

        public void Login(string email, string password)
        {
            if (email == "charbelkiwan@gmail.com" && password == "kiwan123")
            {
                LoginEvent1(email, password);
            }
            else
            {
                LoginEvent2(email, password);
            }
        }
        public override string ToString()
        {
            return string.Format("{0} - {1:C}", Title, Price);
        }
  
    }
}
