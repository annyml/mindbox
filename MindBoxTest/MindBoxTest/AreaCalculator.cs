namespace MindBoxTest
{
    /// <summary>
    /// Класс для вычисления площади фигур
    /// </summary>
    public class AreaCalculator
    {
        /// <summary>
        /// Вычисление площади фигур
        /// </summary>
        /// <param name="shape">Фигура</param>
        /// <returns>Площадь</returns>
        public static double Calculate(Shape shape) => shape.GetSquare();
    }
}
