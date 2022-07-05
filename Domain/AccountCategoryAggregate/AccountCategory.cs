using Domain.AccountAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.AccountCategoryAggregate
{
    public class AccountCategory
    {
        public AccountCategory()
        {
            Accounts = new HashSet<Account>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public HashSet<Account> Accounts { get; set; }
    }

    public class AccountCategoryRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
