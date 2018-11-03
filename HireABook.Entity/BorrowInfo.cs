using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireABook.Entity
{
    public class BorrowInfo
    {
        [Key]
        public int BorrowId { get; set; }
        public string BorrowedBy { get; set; }
        public bool IsReturned { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public double BorrowPrice { get; set; }
        public int BookId { get; set; }
    }
}
