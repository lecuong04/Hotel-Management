using Hotel_Management.Models;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Hotel_Management.Tests
{
    [TestFixture]
    public class DbContextTest
    {
        DbContext db = new DbContext(DbContext.ConnectionType.ConfigurationManager, "DefaultConnection");

        [Test]
        public void GetTable()
        {
            Expression<Func<Employee, bool>> condition = x => x.Gender == "Nữ" || x.Phone.StartsWith("0");
            var _1 = db.GetTable<Employee>(condition);
            TestContext.Write(_1.Count());
        }
        
        [Test]
        public void GetTableTest()
        {
            var room = db.GetTable("SELECT * FROM LOAIPHONG").Parse<RoomType>();
            Assert.Pass(room.Count().ToString());
        }

        [Test]
        public void AddRow()
        {
            Employee empl = db.AddRow(new Employee()
            {
                FullName = "Lê Ngọc Cường",
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
        public void DeleteRow() {
            Employee test1 = new Employee()
            {
                FullName = "Test 1",
                Phone = "1650173488",
                UniqueNumber = "433711744341",
                Address = "Test 1",
                Gender = "Nam",
                Position = "1",
                DoW = DateTime.Now,
            };
            Employee result = db.AddRow(test1);
            if (result.FullName == test1.FullName)
            {
                TestContext.WriteLine(test1.FullName);
                TestContext.WriteLine(db.DeleteRow(result));
            }
        }

        [Test]
        public void DeleteRows()
        {
            Employee test1 = new Employee()
            {
                FullName = "Test 1",
                Phone = "1650173488",
                UniqueNumber = "433711744341",
                Address = "Test 1",
                Gender = "Nam",
                Position = "1",
                DoW = DateTime.Now,
            };
            if (db.AddRow(test1).FullName == test1.FullName)
                TestContext.WriteLine(test1.FullName);
            Employee test2 = new Employee()
            {
                FullName = "Test 2",
                Phone = "9456300926",
                UniqueNumber = "119296133729",
                Address = "Test 2",
                Gender = "Nữ",
                Position = "1",
                DoW = DateTime.Now,
            };
            if (db.AddRow(test2).FullName == test2.FullName)
                TestContext.WriteLine(test2.FullName);
            Employee test3 = new Employee()
            {
                FullName = "Test 3",
                Phone = "4032312399",
                UniqueNumber = "321754829448",
                Address = "Test 3",
                Gender = "Nữ",
                Position = "1",
                DoW = DateTime.Now,
            };
            if (db.AddRow(test3).FullName == test3.FullName)
                TestContext.WriteLine(test3.FullName);
            int result = db.DeleteRows<Employee>(x => x.Position == "1" || x.Gender == "Nam");
            ClassicAssert.AreEqual(3, result);
        }
    }
}
