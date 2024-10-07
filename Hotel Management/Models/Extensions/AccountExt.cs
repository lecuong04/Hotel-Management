using Hotel_Management.Contexts;
using System.Linq;

namespace Hotel_Management.Models.Extensions
{
    public static class AccountExt
    {
        public static Employee GetEmployee(this Account account, DbContext context)
        {
            return context.GetTable<Employee>(x => x.Id == account.Employee).FirstOrDefault();
        }
    }
}
