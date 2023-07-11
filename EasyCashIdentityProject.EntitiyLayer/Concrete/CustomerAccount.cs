using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntitiyLayer.Concrete
{
    public class CustomerAccount
    {
        public  int CustomerAccountID { get; set; }
        public string AccountNumber { get; set; }
        public string AccountCurrency { get; set; }
        public decimal AccountBalance { get; set; }
        public string BankBranch { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }


    }
}
