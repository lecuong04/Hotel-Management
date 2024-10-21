using Hotel_Management.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hotel_Management.ViewModels
{
    public class AccountViewModel
    {
        Employee employee;
        public Employee Employee => employee;

        Account account;
        public Account Account => account;

        public string FullName { get; set; }
        public string UniqueNumber { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string CreatedAt { get; set; }
        public string IsActive { get; set; }

        public AccountViewModel(Account account, DbContext db)
        {
            this.account = account;
            employee = db.GetTable<Employee>(x => x.Id == account.Employee).First();
            FullName = employee.FullName;
            UniqueNumber = employee.UniqueNumber;
            Password = account.Password;
            Role = account.Role;
            CreatedAt = account.CreatedAt.ToString("dd-MM-yyyy");
            IsActive = account.IsActive ? "Có" : "Không";
        }

        public static IEnumerable<AccountViewModel> GetAccounts(DbContext db)
        {
            foreach (Account account in db.GetTable<Account>())
            {
                yield return new AccountViewModel(account, db);
            }
        }
    }
}
