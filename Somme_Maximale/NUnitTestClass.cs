using NUnit.Framework;
using System;
namespace Somme_Maximale
{
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test()]
        public void MaxMeanWindow()
        {
            double[] temp = { 13.1, 10.7, 11.7, 12.4, 10.2, 8.1,
                10.5, 12.4, 9.9, 11.2 };

            double[] temp2 = { 13.1, 10.7, 11.7, 12.4, 10.2, 8.1,
                10.5, 12.4, 10.9, 13.2 };

            Assert.AreEqual(11.83, MainClass.MaxMeanWindow(temp, 3));
            Assert.AreEqual(12.17, MainClass.MaxMeanWindow(temp2, 3));
        }
    }
}
