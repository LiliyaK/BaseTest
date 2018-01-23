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
        public ItemServiceTest()
        {
            AutoMapperConfig.Initialize();
            this.itemService = new ItemsService(@"C:\Users\KamaletdinovaL\Documents\FilesForPriceList\3.xml");
        }


        [Test]
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
            //List<Item> itemsTest = new List<Item>() { new Item { Date = DateTime.Now, BrandName = "Brand3", Price = 400 } };
            Assert.AreEqual(itemService.GetAll().Count, 1);
        }
        [Test]
        public void Save_Test()
        {
            
        }
    }
}