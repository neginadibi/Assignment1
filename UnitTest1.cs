using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NotTriangleTest1()
        {
            //Arrange
            int first = 10;
            int second = 1;
            int third = 3;

            string expected = "It is not a triangle";
            TriangleSolver.Analyze(first, second, third);

            //Act
            string actual = TriangleSolver.Analyze(first, second, third);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotTriangleTest2()
        {
            //Arrange
            int first = 9000;
            int second = 1000;
            int third = 2000;

            string expected = "It is not a triangle";
            TriangleSolver.Analyze(first, second, third);

            //Act
            string actual = TriangleSolver.Analyze(first, second, third);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsoscelesTest1()
        {
            //Arrange
            int first = 100;
            int second = 100;
            int third = 70;

            string expected = "It is an Isosceles triangle";
            TriangleSolver.Analyze(first, second, third);

            //Act
            string actual = TriangleSolver.Analyze(first, second, third);
            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void IsoscelesTest2()
        {
            //Arrange
            int first = 40;
            int second = 40;
            int third = 20;

            string expected = "It is an Isosceles triangle";
            TriangleSolver.Analyze(first, second, third);

            //Act
            string actual = TriangleSolver.Analyze(first, second, third);

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void EquilateralTest1()
        {
            //Arrange
            int first =15;
            int second = 15;
            int third = 15;

            string expected = "It is an equilateral triangle";
            TriangleSolver.Analyze(first, second, third);
            //Act
            string actual = TriangleSolver.Analyze(first, second, third);
            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void EquilateralTest2()
        {
            //Arrange
            int first = 3000;
            int second = 3000;
            int third = 3000;

            string expected = "It is an equilateral triangle";
            TriangleSolver.Analyze(first, second, third);
            //Act
            string actual = TriangleSolver.Analyze(first, second, third);
            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void scaleneTest1()
        {
            //Arrange
            int first = 5;
            int second = 3;
            int third = 4;

            string expected = "It is a scalene triangle";
            TriangleSolver.Analyze(first, second, third);
            //Act
            string actual = TriangleSolver.Analyze(first, second, third);
            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void scaleneTest2()
        {
            //Arrange
            int first = 5000;
            int second = 9000;
            int third = 10000;

            string expected = "It is a scalene triangle";
            TriangleSolver.Analyze(first, second, third);
            //Act
            string actual = TriangleSolver.Analyze(first, second, third);
            //Assert
            Assert.AreEqual(expected, actual);


        }

        
    }
}
