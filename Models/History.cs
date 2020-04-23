using System;
using System.ComponentModel.DataAnnotations;
namespace BankAccount.Models
{
    public class History
    {
        [Key]
        public int HistoryId {get;set;}
        [Required]
        public decimal Amount {get;set;}
        public DateTime Date {get;set;} = DateTime.Now;
        public User Owner {get;set;}
        public int UserId { get; set; }
    }
}
