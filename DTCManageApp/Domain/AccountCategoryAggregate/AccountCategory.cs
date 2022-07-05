using DTCManageApp.Domain.AccountAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTCManageApp.Domain.AccountCategoryAggregate
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
        public string CreatedTimeToString
        {
            get
            {
                return CreatedTime.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        public HashSet<Account> Accounts { get; set; }
    }

    public class AccountCategoryRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
