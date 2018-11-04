using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireABook.Entity
{
    public class BookInfo
    {
        [Key]
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public string ISBN { get; set; }
        public string Edition { get; set; }
        public double OriginalPrice { get; set; }
        public int GenreId { get; set; }
        public string FrontCover { get; set; }
        public int SearchCount { get; set; }
        public string AddedBy { get; set; }
        public bool IsApproved { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime UploadDate { get; set; }
        public int UserId { get; set; }
        [NotMapped]
        public string GenreName { get; set; }
        [NotMapped]
        public string UserName { get; set; }

    }
}
