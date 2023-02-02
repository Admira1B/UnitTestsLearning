using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLab;

namespace UnitTestLab
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void DistanceToPoint_neg5_10_point1And4_neg12_point2_23_7697returned()
        {
            Point point1 = new Point(-5, 10, "point1");
            Point point2 = new Point(4, -12, "point2");

            double expected = 23.7697286480094;
            double actual = point1.DistanceToPoint(point2);

            Assert.AreEqual(Math.Round(expected, 4), Math.Round(actual, 4));
        }

        [TestMethod]
        public void DistanceToX_neg5_10_point1And4_neg12_point2_point2returned()
        {
            Point point1 = new Point(-5, 10, "point1");
            Point point2 = new Point(4, -12, "point2");

            string expected = "point2 ближе к оси X";
            string actual = point1.DistanceToX(point2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DistanceToX_neg3_10_point1And4_neg12_point2_point1returned()
        {
            Point point1 = new Point(-3, 10, "point1");
            Point point2 = new Point(4, -12, "point2");

            string expected = "point1 ближе к оси X";
            string actual = point1.DistanceToX(point2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DistanceToX_neg3_10_point1And3_neg12_point2_pointsreturned()
        {
            Point point1 = new Point(-3, 10, "point1");
            Point point2 = new Point(3, -12, "point2");

            string expected = "Расстояние точек до оси X равно!";
            string actual = point1.DistanceToX(point2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DistanceToY_neg5_10_point1And4_neg12_point2_point1returned()
        {
            Point point1 = new Point(-5, 10, "point1");
            Point point2 = new Point(4, -12, "point2");

            string expected = "point1 ближе к оси Y";
            string actual = point1.DistanceToY(point2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DistanceToY_neg5_10_point1And4_neg9_point2_point2returned()
        {
            Point point1 = new Point(-5, 10, "point1");
            Point point2 = new Point(4, -9, "point2");

            string expected = "point2 ближе к оси Y";
            string actual = point1.DistanceToY(point2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DistanceToY_neg3_10_point1And4_neg10_point2_pointsreturned()
        {
            Point point1 = new Point(-3, 10, "point1");
            Point point2 = new Point(4, -10, "point2");

            string expected = "Расстояние точек до оси Y равно!";
            string actual = point1.DistanceToY(point2);

            Assert.AreEqual(expected, actual);
        }
    }
}