using System.ComponentModel.DataAnnotations;
using System;

namespace bankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public bool Deposit { get; set; } = false;

        public int UserId {get;set;}

        public User User {get;set;}

        public int Amount {get;set;}
        public DateTime TransactionAt {get;set;} = DateTime.Now;
    }
}