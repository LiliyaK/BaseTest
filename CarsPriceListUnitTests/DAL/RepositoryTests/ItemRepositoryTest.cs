using System;
using NUnit.Framework;
using DAL.Entities;
using DAL.Repository;
using System.Collections.Generic;

namespace CarsPriceListUnitTests.DAL
{
    [TestFixture]
    public class ItemRepositoryTest
    {
        ItemRepository itemRepository;
        [SetUp]
        public void Init()
        {
            List<Item> items = new List<Item>() { new Item { Date = DateTime.Now, BrandName = "Brand", Price = 200 }, new Item { Date = DateTime.Now, BrandName = "Brand2", Price = 223 } };
            itemRepository = new ItemRepository(items);

        }
        [Test]
        public void Test_Add()
        {
            Item item = new Item();
            itemRepository.Add(item);
            Assert.IsTrue(itemRepository.items.Contains(item));
        }
        [Test]
        public void Test_Delete()
        {
            Item item = new Item();
            itemRepository.Delete(item);
            Assert.IsFalse(itemRepository.items.Contains(item));
        }
        [Test]
        public void Test_GetAll()
        {
            Assert.AreEqual(itemRepository.items.Count, 2);
        }
    }
}
