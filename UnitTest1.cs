using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;


namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
         
            int[] mat1 = new[] { 1, 2, 3, 3, 5, 6, 7, 8, 9 };
            int[] mat2 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool extd = false;
            
            bool actual = ClassTest.test(mat1, mat2);
            
            Assert.AreEqual(extd, actual);
        }
    }
}