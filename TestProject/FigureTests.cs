
using HomeworkByMindbox.lab;

namespace TestProject
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void CircleFormulaTest()
        {
            //arrange
            double r = 10;
            double expected = 314;

            //act
            double actual = Figure.CircleArea(r);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TriangleFormulaTest()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            double expected = 6.0;

            double actual = Figure.TriangleArea(a, b, c);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void RightAngledTriangleTest()
        {
            double a = 4.0;
            double b = 5.0;
            double c = 3.0;

            bool expected = Figure.RightAngledTriangle(a, b, c);

            Assert.IsTrue(expected);
        }
    }
}
