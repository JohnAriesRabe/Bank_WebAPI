using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bank_WebAPI.Models
{
    public class b_user
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string userID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string fullName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string mobile { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string password { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string password_salt { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string pin { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string pin_salt { get; set; }
    }
}
