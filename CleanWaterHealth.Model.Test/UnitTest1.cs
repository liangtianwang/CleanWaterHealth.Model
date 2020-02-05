using CleanWaterHealth.Model.Domain;
using CleanWaterHealth.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanWaterHealth.Model.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ItemContext>();
            optionsBuilder.UseSqlServer("Server=34.87.237.207;Database=CWH;User Id=sqlserver;Password=123456");

            var context = new ItemContext(optionsBuilder.Options);

            // Create
            context.Add(new Item { ItemCode = "2", Description = "12" });
            context.SaveChanges();

            Assert.AreEqual(1, 1);

        }
    }
}
