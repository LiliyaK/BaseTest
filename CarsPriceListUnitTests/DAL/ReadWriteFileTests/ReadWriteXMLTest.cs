using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using DAL.Interfaces;
using DAL.ReadWriteFile;
using DAL.Entities;

namespace CarsPriceListUnitTests.DAL.ReadWriteFileTests
{
    [TestFixture]
    public class ReadWriteXMLTest
    {
        private IRead reader;
        private IWrite writer;
        readonly string root = @"C:\Users\KamaletdinovaL\Documents\FilesForPriceList\1.xml";
        private List<Item> items;
        public ReadWriteXMLTest()
        {
            FileStream fileStream = new FileStream(this.root, FileMode.OpenOrCreate);
            this.reader = new ReadXML(fileStream);
            this.writer = new WriteXML(fileStream);
            this.items = new List<Item>() { new Item { Date = DateTime.Now, BrandName = "Brand", Price = 200 }, new Item { Date = DateTime.Now, BrandName = "Brand2", Price = 223 } };
        }
        [Test]
        public void Test_Write()
        {
            this.writer.Write(this.items);
            Assert.AreEqual(this.reader.Read(), items);
        }
        [Test]
        public void Test_Read()
        {
            Assert.AreEqual(this.reader.Read(), items);
        }
    }
}
