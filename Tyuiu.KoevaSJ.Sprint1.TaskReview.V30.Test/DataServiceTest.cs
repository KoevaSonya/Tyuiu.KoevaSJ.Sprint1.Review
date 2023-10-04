using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint1.TaskReview.V30.Lib;

namespace Tyuiu.KoevaSJ.Sprint1.TaskReview.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 5.472;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
