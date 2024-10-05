using Hotel_Management.Contexts;
using Hotel_Management.Models;
using NUnit.Framework;
using System;
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
            var result = context.GetTable<Employee>();
            Assert.Pass(result.Count().ToString());
        }

        [Test]
        public void AddColumn()
        {
            DbContext context = new DbContext();
            context.UseConfigurationManager("DefaultConnection");
            bool result = context.AddRow(new Employee()
            {
                Name = "Lê Ngọc Cường",
                Phone = "0868937404",
                UniqueNumber = "031204000632",
                Address = "Bà Điểm, Hóc Môn, TP.HCM",
                Gender = "Nam",
                Position = "Trưởng phòng nhân sự",
                DoW = new DateTime(2024, 04, 02)
            });
            if (result) { 
                Employee cuong = context.GetTable<Employee>(x => x.UniqueNumber == "031204000632").FirstOrDefault();
                if (cuong != null) {
                    result = context.AddRow(new Account()
                    {
                        Employee = cuong.Id,
                        Role = "Quản trị viên",
                        Password = BCrypt.Net.BCrypt.HashPassword("LeCuong_04"),
                        IsActive = true
                    });
                }
            }
            Assert.Pass(result.ToString());
        }
    }
}
