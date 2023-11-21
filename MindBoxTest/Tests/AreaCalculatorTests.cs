namespace Tests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        //допустимая погрешность для вычисления
        private static readonly double eps = 0.00001;

        [TestMethod]
        public void Circle()
        {
            var s = AreaCalculator.Calculate(new Circle(4));
            Assert.AreEqual(16, s);
        }

        [TestMethod]
        public void Triangle_Rect()
        {
            var s = AreaCalculator.Calculate(new Triangle(4, 3, 5));
            Assert.AreEqual(6, s);
        }

        [TestMethod]
        public void Triangle()
        {
            var s = AreaCalculator.Calculate(new Triangle(7, 7, 8));
            Assert.IsTrue(Math.Abs(s - 22.978250586152) < eps);
        }
    }
}