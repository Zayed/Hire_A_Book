using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireABook.Entity
{
    public class DataContext:DbContext
    {
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<BookInfo> BookInfo { get; set; }
        public DbSet<BorrowInfo> BorrowInfo { get; set; }
        public DbSet<GenreInfo> GenreInfo { get; set; }
    }
}
