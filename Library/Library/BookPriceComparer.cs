using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookPriceComparer : IComparer<Books>
    {
         public int Compare(Books x, Books y)
        {
            if (x.Price < y.Price)
            {
                return -1;
            }
            else if (x.Price > y.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

}
