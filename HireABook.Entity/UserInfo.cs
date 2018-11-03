using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireABook.Entity
{
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNo { get; set; }
        public int UserRole { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastSeen { get; set; }
        public string City { get; set; }
        public string Thana { get; set; }
        public string Area { get; set; }
        public string IPAddress { get; set; }
        public int MyProperty { get; set; }
    }
}
