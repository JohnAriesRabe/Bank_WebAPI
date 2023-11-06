﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_WebAPI.Models
{
    public class b_savings
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string userID { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public decimal credit_amount { get; set; }
    }
}
