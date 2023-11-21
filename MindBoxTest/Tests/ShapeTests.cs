namespace Tests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void TestCircle()
        {
            var c = new Circle(10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircle_NegativeRadius()
        {
            var c = new Circle(-1);
        }

        [TestMethod]
        public void TestCircle_0Radius()
        {
            var c = new Circle(0);
        }

        [TestMethod]
        public void TestTriangle()
        {
            var t = new Triangle(7, 8, 7);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangle_Negative()
        {
            var t = new Triangle(-1, 10, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangle_0()
        {
            var t = new Triangle(0, 0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangle_WrongLength()
        {
            var t = new Triangle(1, 1, 2);
        }
    }
}
