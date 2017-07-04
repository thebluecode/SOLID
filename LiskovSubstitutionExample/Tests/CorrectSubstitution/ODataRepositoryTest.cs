using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CorrectSubstitution;
using System.Linq;

namespace Tests.CorrectSubstitution
{
    [TestClass]
    public class ODataRepositoryTest
    {
        [TestMethod]
        public void Should_Return_Product_Inserted()
        {
            var repository = new ODataRepository();

            repository.ProductList = null;

            var product = new Product()
            {
                Name = "Ball",
                Price = 100
            };

            repository.Insert(product);

            Assert.IsTrue(repository.GetList().Any(x => x.Name == "Ball" && x.Price == 100));
        }
    }
}
