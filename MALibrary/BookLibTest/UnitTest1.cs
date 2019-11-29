using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using ClassLibrary2;
using System;

namespace BookLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTitleLenght()
        {
            //Arrange|
            Book mybook = new Book();
            //mybook.Title = "IT";
            // string i;
            Assert.ThrowsException<Exception>(() =>
            {
                string i = "1";
                mybook.Title = i;
            });
        }
        [TestMethod]
        public void TestISBMLenghtLESS()
        {
            //Arrange|
            Book mybook = new Book();

            Assert.ThrowsException<Exception>(() =>
            {
                string i = "1";
                mybook.ISBN13 = i;
            });
        }
        [TestMethod]
        public void TestISBMLenghtMORE()
        {
            //Arrange|
            Book mybook = new Book();

            Assert.ThrowsException<Exception>(() =>
            {
                string i = "aaaaaaaaaaaa";
                mybook.ISBN13 = i;
            });
        }
        [TestMethod]
        public void TestPageNumberLenghtLESS()
        {
            //Arrange|
            Book mybook = new Book();

            Assert.ThrowsException<Exception>(() =>
            {
                int i = 1;
                mybook.PageNumber = i;
            });
        }
        [TestMethod]
        public void TestPageNumberLenghtMORE()
        {
            //Arrange|
            Book mybook = new Book();

            Assert.ThrowsException<Exception>(() =>
            {
                int i = 1001;
                mybook.PageNumber = i;
            });

        }
        [TestMethod]
        public void IsAuthorEmpty()
        {
            //Arrange|
            Book mybook = new Book();

            Assert.ThrowsException<Exception>(() =>
            {
                string i = "";
                mybook.Author = i;
            });
        }
        
    }
}
