using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using BLL.Settings;

namespace CarsPriceListUnitTests.Setting
{
    [SetUpFixture]
    public class AutoMapperConfigTest
    {
        [OneTimeSetUp]
        public void Init()
        {
            AutoMapperConfig.Initialize();
        }
        [OneTimeTearDown]
        public void Test() { }
    }
}
