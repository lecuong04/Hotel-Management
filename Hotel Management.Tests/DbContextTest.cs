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
        DbContext db = new DbContext();

        [SetUp]
        public void SetUp()
        {
            db.UseConfigurationManager("DefaultConnection");
        }


        [Test]
        public void GetTable()
        {
            var result = db.GetTable<Employee>();
            Assert.Pass(result.Count().ToString());
        }

        [Test]
        public void AddRow()
        {
            bool result = db.AddRow(new Employee()
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
                Employee cuong = db.GetTable<Employee>(x => x.UniqueNumber == "031204000632").FirstOrDefault();
                if (cuong != null) {
                    result = db.AddRow(new Account()
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

        [Test]
        public void UpdateRow() {
            Employee cuong = db.GetTable<Employee>(x => x.UniqueNumber == "031204000632").FirstOrDefault();
            cuong.DoW = new DateTime(2024, 04, 01);
            cuong.Gender = "Nữ";
            cuong.Phone = "0123456789";
            bool result = db.UpdateRow(cuong);
            Assert.Pass(result.ToString());
        }
    }
}
