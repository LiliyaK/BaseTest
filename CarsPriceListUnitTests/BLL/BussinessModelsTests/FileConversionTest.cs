using System;
using NUnit.Framework;
using BLL.DTO;
using BLL.BussinessModels;

namespace CarsPriceListUnitTests.BLL.BussinessModelsTests
{
    [TestFixture]
    public class FileConversionTest
    {
        private FormatConversion formatConvertion;
        readonly string root = @"C:\Users\KamaletdinovaL\Documents\FilesForPriceList\3.xml";
        public FileConversionTest()
        {
            this.formatConvertion = new FormatConversion( new FileDTO(this.root));
        }
        [Test]
        public void Test_Converse()
        {
            Assert.AreNotEqual(formatConvertion.Converse(),this.root);
        }
    }
}
