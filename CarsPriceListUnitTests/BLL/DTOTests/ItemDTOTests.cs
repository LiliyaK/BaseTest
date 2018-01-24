using System;
using NUnit.Framework;
using BLL.DTO;

namespace CarsPriceListUnitTests.BLL.DTOTests
{
    [TestFixture]
    public class ItemDTOTests
    {
        private ItemDTO item;
        public ItemDTOTests()
        {
            this.item = new ItemDTO(DateTime.Now, "Alpha", 1200);
        }

        [Test]
        public void Date_Property_Test()
        {
            DateTime expected= DateTime.MinValue;
            this.item.Date = expected;
            Assert.AreEqual(this.item.Date,expected);
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
        public void Test_ToString()
        {
            Assert.AreEqual(this.item.ToString(), this.item.Date.Date.ToShortDateString() + " " + this.item.BrandName + " " + this.item.Price);
        }
    }
}
