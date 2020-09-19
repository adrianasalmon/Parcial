using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialAdrianaSalmon.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetCountry()
        {
            //Arrange
            CountriesController countriesController = new CountriesController();
            //Act
            var Lista = countriesController.GetCountries();
            //Asser
            Assert.IsNotNull(Lista);
        }
    }
}
