using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using DAL.Entities;
using BLL.DTO;
using DAL.Interfaces;
using BLL.Interfaces;
using AutoMapper;
using BLL.Services;
using BLL.Settings;
using Core.Infrastructure;

namespace CarsPriceListUnitTests.BLL
{
    /// <summary>
    /// Summary description for ItemServiceTest
    /// </summary>
    [TestFixture]
    public class ItemServiceTest
    {
        Mock<IRepository> itemRepository;
        private IItemService itemService;
        [SetUp]
        public void Init()
        {
            this.itemService = new ItemsService(@"C:\Users\KamaletdinovaL\Documents\FilesForPriceList\3.xml");
        }

        //[Test]
        public void Add_Test()
        {
            Item item = new Item() { Date=DateTime.Parse("10.10.2008"),BrandName= "Alpha Romeo Brera",Price= 37000 };
            itemService.Add(Mapper.Map<Item, ItemDTO>(item));
            Assert.IsFalse(itemService.GetAll().Contains(Mapper.Map<Item,ItemDTO>(item)));
        }

        [Test]
        public void Delete_Test()
        {
            Item item = new Item() { Date = DateTime.Parse("10.10.2008"), BrandName = "Alpha Romeo Brera", Price = 37000 };
            itemService.Delete(Mapper.Map<Item, ItemDTO>(item));
            Assert.IsFalse(itemService.GetAll().Contains(Mapper.Map<Item, ItemDTO>(item)));
        }

        [Test]
        public void GetAll_Test()
        {
            Item item = new Item() { Date = DateTime.Parse("10.10.2008"), BrandName = "Alpha Romeo Brera", Price = 37000 };
            Assert.AreEqual(itemService.GetAll(), item);
        }
        [Test]
        public void Test_Add_ThrowsNullException()
        {
            ValidationException exception = Assert.Throws<ValidationException>(delegate { itemService.Add(null); });
            Assert.AreEqual("Item is not initialized", exception.Message);
        }
        [Test]
        public void Test_Delete_ThrowsNullException()
        {
            ValidationException exception = Assert.Throws<ValidationException>(delegate { itemService.Delete(null); });
            Assert.AreEqual("Item is not initialized", exception.Message);
        }
    }
}