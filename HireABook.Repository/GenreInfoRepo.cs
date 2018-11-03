using HireABook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireABook.Repository
{
    public class GenreInfoRepo
    {
        private DataContext DataContextOb = new DataContext();
        public List<GenreInfo> GetAll()
        {
            List<GenreInfo> GenreInfoList = DataContextOb.GenreInfo.ToList();

            return GenreInfoList;
        }

    }
}
