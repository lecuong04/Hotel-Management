using Hotel_Management.Contexts;
using Hotel_Management.Models;
using NUnit.Framework;
using System.Linq;

namespace Hotel_Management.Tests
{
    [TestFixture]
    public class DbContextTest
    {
        [Test]
        public void GetTable()
        {
            DbContext context = new DbContext();
            context.UseConfigurationManager("DefaultConnection");
            var result = context.GetTable<Customer>();
            Assert.Pass(result.Count().ToString());
        }
    }
}
