using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using BLL;
using BLL.Services;
using DAL.Entities;
using AutoMapper;
using BLL.DTO;
using BLL.Settings;

namespace CarsPriceListUnitTests.BLL
{
    [TestFixture]
    public class FileServiceTest
    {
        private IFileService fileService;
        List<Item> items;
       
        public FileServiceTest()
        {
            AutoMapperConfig.Initialize();
            fileService = new FileService(@"C: \Users\KamaletdinovaL\Documents\FilesForPriceList\3.xml");
            items = new List<Item>() { new Item() { Date = DateTime.Parse("10.10.2008"), BrandName = "Alpha Romeo Brera", Price = 37000 }
        };
        }
        [Test]
        public void Test_Read()
        {
            Assert.AreEqual(fileService.Read(),Mapper.Map<List<Item>,List<ItemDTO>>(items));
        }
        [Test]
        public void Test_Write_IsConverted_False()
        {
            Assert.AreEqual(fileService.Read(), items);
        }
        [Test]
        public void Test_Write_IsConverted_True()
        {
            items.Add(new Item { Date = DateTime.Now, BrandName = "Brand", Price = 200 });
            fileService.Write(Mapper.Map<List<Item>, List<ItemDTO>>(items), false);
            Assert.AreEqual(fileService.Read(), items);
        }
    }
}
