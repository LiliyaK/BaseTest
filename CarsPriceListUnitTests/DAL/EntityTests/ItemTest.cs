using System;
using NUnit.Framework;
using DAL.Entities;

namespace CarsPriceListUnitTests.DAL.EntityTests
{
    [TestFixture]
    public class ItemTest
    {
        private Item item;
        public ItemTest()
        {
            this.item = new Item(DateTime.Now, "Alpha", 1200);
        }
        [Test]
        public void Date_Property_Test()
        {
            DateTime expected = DateTime.MinValue;
            this.item.Date = expected;
            Assert.AreEqual(this.item.Date, expected);
        }
        [Test]
        public void BrandName_Proprerty_Test()
        {
            string expected = "Alpha Betta";
            this.item.BrandName = expected;
            Assert.AreEqual(this.item.BrandName, expected);
        }
        [Test]
        public void Price_Property_Test()
        {
            int expected = 12000;
            this.item.Price = expected;
            Assert.AreEqual(this.item.Price, expected);
        }
        [Test]
        public void Test_Not_Equals_To_Object()
        {
            Object otherObject = null;
            Assert.IsFalse(this.item.Equals(otherObject));
        }
        [Test]
        public void Test_Equals_To_Object()
        {
            Object otherObject =new Item(DateTime.Now, "Alpha", 1200);
            Assert.IsTrue(this.item.Equals(otherObject));
        }

    }
}
