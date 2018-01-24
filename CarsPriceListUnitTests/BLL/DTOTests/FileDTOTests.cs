using System;
using NUnit.Framework;
using BLL.DTO;

namespace CarsPriceListUnitTests.BLL.DTOTests
{
    [TestFixture]
    public class FileDTOTests
    {
        readonly string root = @"C:\Users\KamaletdinovaL\Documents\FilesForPriceList\3.xml";
        private FileDTO file;
        public FileDTOTests()
        {
            this.file = new FileDTO(this.root);
        }
        [Test]
        public void FileRoot_Property_Test()
        {
            string expected= @"C:\Users\KamaletdinovaL\Documents\FilesForPriceList\1.xml";
            this.file.FileRoot = expected;
            Assert.AreEqual(this.file.FileRoot,expected);
        }
        [Test]
        public void Extension_Property_Test()
        {
            Assert.AreEqual(this.file.Extention, ".xml");
        }
        
    }
}
