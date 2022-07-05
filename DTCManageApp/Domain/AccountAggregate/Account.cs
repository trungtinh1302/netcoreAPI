using DTCManageApp.Domain.AccountCategoryAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTCManageApp.Domain.AccountAggregate
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumbers { get; set; }
        public int Gender { get; set; }
        public DateTime CreatedTime { get; set; }
        public Account CreadtedBy { get; set; }
        public bool Status { get; set; }
        public int AccountCategoryID { get; set; }
        [ForeignKey("AccountCategoryID")]
        public AccountCategory AccountCategory { get; set; }
    }
}
