using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeerLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerLib.Tests
{
    [TestClass()]
    public class BeerTests
    {
        private Beer beer;

        [TestInitialize]
        public void Init()
        {
            beer = new Beer(1, "Corona", 10, 25);
        }

        [TestMethod()]
        public void NameTest()
        {
            //beer.Name = "Corona";
            Assert.AreEqual(expected: "Corona", actual: beer.Name);

            Assert.ThrowsException<ArgumentException>(() => beer.Name = "A");

            Assert.ThrowsException<ArgumentNullException>(() => beer.Name = null);
        }

        [TestMethod()]
        public void PriceTest()
        {
            //beer.Price = 10;
            Assert.AreEqual(expected: 10, actual: beer.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => beer.Price = -1));
        }

        [TestMethod()]
        public void AbvTest()
        {
            //beer.Abv = 25;
            Assert.AreEqual(expected: 25, actual: beer.Abv);
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => beer.Abv = -1));
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => beer.Abv = 101));
        }


        [TestMethod()]
        public void ToStringTest()
        {
            //beer.Id = 1;
            //beer.Name = "Corona";
            //beer.Price = 10;
            //beer.Abv = 25;
            string result = beer.ToString();
            Assert.AreEqual(expected: "1 Corona 10 25", actual: result);
        }
    }
}