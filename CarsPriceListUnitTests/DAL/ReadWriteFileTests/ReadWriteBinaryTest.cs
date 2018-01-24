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
    public class ReadWriteBinaryTest
    {
        private IRead reader;
        private IWrite writer;
        readonly string root = @"C:\Users\KamaletdinovaL\Documents\FilesForPriceList\6.bin";
        FileStream fileStream;
        private List<Item> items;
        public ReadWriteBinaryTest()
        {
            fileStream = new FileStream(this.root,FileMode.OpenOrCreate);
            this.reader = new ReadBinary(fileStream);
            this.writer = new WriteBinary(fileStream);
            this.items = new List<Item>() { new Item { Date = DateTime.Now, BrandName = "Brand", Price = 200 }, new Item { Date = DateTime.Now, BrandName = "Brand2", Price = 223 } };
        }
        [Test]
        public void Test_Write()
        {
            this.writer.Write(this.items); fileStream.Seek(0, SeekOrigin.Begin);
            Assert.AreEqual(this.reader.Read(),this.items);
        }
        [Test]
        public void Test_Read()
        {
            Assert.AreEqual(this.reader.Read(), items);
        }
    }
}
