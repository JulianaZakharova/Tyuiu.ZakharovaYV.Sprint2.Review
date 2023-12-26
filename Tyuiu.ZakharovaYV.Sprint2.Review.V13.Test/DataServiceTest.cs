using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZakharovaYV.Sprint2.Review.V13.Lib;

namespace Tyuiu.ZakharovaYV.Sprint2.Review.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
            public void CheckDotInShadedAreaValid()
            {
                DataService ds = new DataService();
                double x = 1;
                double y = 1;
                bool res = ds.CheckDotInShadedArea(x, y);
                bool wait = true;
                Assert.AreEqual(res, wait);
            }
        
    }
}
