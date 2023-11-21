namespace MindBoxTest
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle
        : Shape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public int Radius { get; init; }

        public Circle(int radius)
        {
            if (radius < 0)
                throw new ArgumentException($"Радиус {radius} меньше 0");

            Radius = radius;
        }   

        internal override double GetSquare()
        {
            return Math.Pow(Radius, 2);
        }
    }
}
