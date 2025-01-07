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
    public class ProgramTests
    {
        [TestMethod()]
        public void NegyzetTest1()
        {
            //Arrange
            int szam = 2;
            int expected = 4;
            //Act
            int actual = Program.Negyzet(szam);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void NegyzetTest2()
        {
            //Arrange
            int szam = 1;
            int expected = 1;
            //Act
            int actual = Program.Negyzet(szam);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void NegyzetTest3()
        {
            //Arrange
            int szam = 0;
            int expected = 0;
            //Act
            int actual = Program.Negyzet(szam);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void NegyzetTest5()
        {
            //Arrange
            int szam = -2;
            int expected = 4;
            //Act
            int actual = Program.Negyzet(szam);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}