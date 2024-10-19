using Hotel_Management.Models;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Linq;
namespace Hotel_Management.Tests
{
    [TestFixture]
    public class DbContextTest
    {
        DbContext db = new DbContext(DbContext.ConnectionType.ConfigurationManager, "DefaultConnection");

        [Test]
        public void GetTable()
        {
            var result = db.GetTable<RoomType>();
            Assert.Pass(result.Count().ToString());
        }

        [Test]
        public void GetRow()
        {
            Room room = db.GetTable<Room>(x => x.Id == 3).First();
            RoomType type = db.GetTable<RoomType>(x => x.Id == room.RoomType).First();
        }

        [Test]
        public void AddRow()
        {
            Employee empl = db.AddRow(new Employee()
            {
                Name = "Lê Ngọc Cường",
                Phone = "0868937404",
                UniqueNumber = "031204000632",
                Address = "Bà Điểm, Hóc Môn, TP.HCM",
                Gender = "Nam",
                Position = "Trưởng phòng nhân sự",
                DoW = new DateTime(2024, 04, 02)
            });
            if (empl.Id > 0)
            {
                Account account = db.AddRow(new Account()
                {
                    Employee = empl.Id,
                    Role = "Quản trị viên",
                    Password = BCrypt.Net.BCrypt.HashPassword("LeCuong_04"),
                    IsActive = true
                });
                Assert.Equals(account.Role, "Quản trị viên");
            } else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void AddRowDev()
        {
            RoomType roomType = db.AddRow(new RoomType() { 
                Name = "Dev",
                Price = 10000,
                MaxPeople = 10,
            });
            Assert.Equals(roomType.Name, "Dev");
        }

        [Test]
        public void UpdateRow()
        {
            Employee cuong = db.GetTable<Employee>(x => x.UniqueNumber == "031204000632").FirstOrDefault();
            cuong.DoW = new DateTime(2024, 04, 01);
            cuong.Gender = "Nữ";
            cuong.Phone = "0123456789";
            bool result = db.UpdateRow(cuong);
            ClassicAssert.IsTrue(result);
        }

        [Test]
        public void DeleteRows()
        {
            Employee test1 = new Employee()
            {
                Name = "Test 1",
                Phone = "1650173488",
                UniqueNumber = "433711744341",
                Address = "Test 1",
                Gender = "Nam",
                Position = "1",
                DoW = DateTime.Now,
            };
            if (db.AddRow(test1).Name == test1.Name)
                TestContext.WriteLine(test1.Name);
            Employee test2 = new Employee()
            {
                Name = "Test 2",
                Phone = "9456300926",
                UniqueNumber = "119296133729",
                Address = "Test 2",
                Gender = "Nữ",
                Position = "1",
                DoW = DateTime.Now,
            };
            if (db.AddRow(test2).Name == test2.Name)
                TestContext.WriteLine(test2.Name);
            Employee test3 = new Employee()
            {
                Name = "Test 3",
                Phone = "4032312399",
                UniqueNumber = "321754829448",
                Address = "Test 3",
                Gender = "Nữ",
                Position = "1",
                DoW = DateTime.Now,
            };
            if (db.AddRow(test3).Name == test3.Name)
                TestContext.WriteLine(test3.Name);
            int result = db.DeleteRows<Employee>(x => x.Position == "1");
            ClassicAssert.AreEqual(3, result);
        }
    }
}
