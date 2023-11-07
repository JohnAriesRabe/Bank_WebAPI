using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Bank_WebAPI.Models
{
    public class User
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
        public string PasswordHash { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public decimal Balance { get; set; }
        //public string pin { get; set; }
        //[Column(TypeName = "varbinary(max)")]
        //public byte[] key { get; set; }
        //[Column(TypeName = "varbinary(max)")]
        //public byte[] iv { get; set; }
    }
}
