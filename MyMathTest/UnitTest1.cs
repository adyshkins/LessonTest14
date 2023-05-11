using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void num16num27summ13()
        {
            //Arrange
            double num1 = 6;
            double num2 = 7;
            double summ = 13;
            
            //Act
            double res = LessonTest14.MyMath.Summ(num1.ToString(), num2.ToString());
            
            //Assert

            Assert.AreEqual(summ, res);
        }

        [TestMethod]
        public void num10num24summ4()
        {
            //Arrange
            double num1 = 0;
            double num2 = 4;
            double summ = 4;

            //Act
            double res = LessonTest14.MyMath.Summ(num1.ToString(), num2.ToString());

            //Assert

            Assert.AreEqual(summ, res);
        }

        [TestMethod]
        public void num1qnum2wsumm0()
        {
            //Arrange
            string num1 = "q";
            string num2 = "w";
            double summ = 0;

            //Act
            double res = LessonTest14.MyMath.Summ(num1.ToString(), num2.ToString());

            //Assert

            Assert.AreEqual(summ, res);
        }
    }
}
