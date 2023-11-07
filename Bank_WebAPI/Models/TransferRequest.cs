
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Bank_WebAPI.Models
{
    public class TransferRequest
    {
        [Key]
        [JsonIgnore]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string userID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string SenderUserId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string ReceiverUserId { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public decimal Amount { get; set; }
    }
}
