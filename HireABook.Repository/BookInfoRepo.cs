using HireABook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireABook.Repository
{
    public class BookInfoRepo
    {
        private DataContext DataContextOb = new DataContext();
        public int InsertBookInfo(BookInfo bookInfoOb)
        {
            DataContextOb.Set<BookInfo>().Add(bookInfoOb);
            return DataContextOb.SaveChanges();
        }
    }
}
