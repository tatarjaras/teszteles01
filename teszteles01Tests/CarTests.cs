using Microsoft.VisualStudio.TestTools.UnitTesting;
using teszteles01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszteles01.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarTest()
        {
            Car car = new Car("Opel", "Astra", 2010);
            Assert.AreEqual("Opel", car.Brand);
        }
        [TestMethod()]
        public void CarTest1()
        {
            Car car = new Car("Opel", "Astra", 2010);
            int expected = 10000;
            Assert.AreEqual(expected, car.Tax);
        }
        [TestMethod()]
        public void CarTest2()
        {
            Car car = new Car("Opel", "Astra", 2020);
            int expected = 20000;
            Assert.AreEqual(expected, car.Tax);
        }
        [TestMethod()]
        public void CarTest3()
        {
            Car car = new Car("Opel", "Astra", 2015);
            int expected = 10000;
            Assert.AreEqual(expected, car.Tax);
        }
        [TestMethod()]
        public void CarTest4()
        {
            Car car = new Car("Opel", "Astra", 2095);
            int expected = 20000;
            Assert.AreEqual(expected, car.Tax);
        }
        [TestMethod()]
        public void CarTest5()
        {
            Car car = new Car("Opel", "Astra", 2090);
            int expected = 0;
            Assert.AreEqual(expected, car.Tax);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Car car = new Car("Opel", "Astra", 2010);
            string expected = "Opel Astra (2010) - 10000 Ft";
            Assert.AreEqual(expected, car.ToString());
        }
    }
}