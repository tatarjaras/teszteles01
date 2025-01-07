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
        public void CarTestA()
        {
            Car car = new Car("Opel", "Astra", 2020);
            int expected = 20000;
            Assert.AreEqual(expected, car.Tax);
        }
        [TestMethod()]
        public void CarTestB()
        {
            Car car = new Car("Opel", "Astra", 2015);
            int expected = 10000;
            Assert.AreEqual(expected, car.Tax);
        }
        [TestMethod()]
        public void CarTestC()
        {
            Car car = new Car("Opel", "Astra", 2010);
            int expected = 10000;
            Assert.AreEqual(expected, car.Tax);
        }
        [TestMethod()]
        public void CarTestD()
        {
            Car car = new Car("Opel", "Astra", 1995);
            int expected = 10000;
            Assert.AreEqual(expected, car.Tax);
        }
        [TestMethod()]
        public void CarTestE()
        {
            Car car = new Car("Opel", "Astra", 1990);
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

        [TestMethod()]
        public void IsveteraneTestA()
        {
            Car car = new Car("Opel", "Astra", 2010);
            Assert.IsFalse(car.Isveterane());
        }
        [TestMethod()]
        public void IsveteraneTestB()
        {
            Car car = new Car("Opel", "Astra", 1995);
            Assert.IsFalse(car.Isveterane());
        }
        [TestMethod()]
        public void IsveteraneTestC()
        {
            Car car = new Car("Opel", "Astra", 1990);
            Assert.IsTrue(car.Isveterane());
        }
    }
}