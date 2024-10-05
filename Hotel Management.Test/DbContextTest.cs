using Hotel_Management.Contexts;
using Hotel_Management.Models;
using NUnit.Framework;
using System.Linq;
using System;

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
            var result = context.GetTable<Employee>();
            Assert.Pass(result.Count().ToString());
        }

        [Test]
        public void AddColumn() 
        {
            DbContext context = new DbContext();
            context.UseConfigurationManager("DefaultConnection");
            bool result = context.AddColumn(new Employee()
            {
                Name = "Lê Ngọc Cường",
                Phone = "0868937404",
                UniqueNumber = "031204000632",
                Address = "Bà Điểm, Hóc Môn, TP.HCM",
                Gender = "Nam",
                Position = "Quản lý kho",
                DoW = new DateTime(2024, 04, 02)
            });
            Assert.Pass(result.ToString());
        }
    }
}
