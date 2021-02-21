using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PracticalTask;

namespace PracticTest
{
    [TestClass]
    public class PracticTest
    {
        

        [TestMethod]
        public void Circle_10_314returned()
        {
            //arrange
            double x = 10;
            double expected = 314;
            //act
            Practic practic = new Practic();
             double actual = practic.Circle(x);
             //assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void Triangle_10and12and11_51_52Returned()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            //act
            Practic practic= new Practic();
            double actual =  practic.Triangle(a, b, c);
            //assert
            Assert.AreEqual(expected,actual);

        }

        [TestMethod]
        public void TriangleIsRight()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            //act
            Practic practic = new Practic();
            bool isRight = practic.IsRightTriangle(a, b, c);
            //assert
            Assert.IsTrue(isRight);

        }


    }
}
