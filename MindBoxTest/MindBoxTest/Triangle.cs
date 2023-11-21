namespace MindBoxTest
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle
        : Shape
    {
        /// <summary>
        /// Длина стороны А
        /// </summary>
        public int A { get; init; }

        /// <summary>
        /// Длина стороны B
        /// </summary>
        public int B { get; init; }

        /// <summary>
        /// Длина стороны C
        /// </summary>
        public int C { get; init; }

        public Triangle(int a, int b, int c)
        {
            Validate(a, b, c);

            A = a;
            B = b;
            C = c;
        }

        private static void Validate(int a, int b, int c)
        {
            // проверим, что данные валидные
            if (a <= 0)
                throw new ArgumentException($"Сторона {nameof(a)} меньше или равна 0");

            if (b <= 0)
                throw new ArgumentException($"Сторона {nameof(b)} меньше или равна 0");

            if (c <= 0)
                throw new ArgumentException($"Сторона {nameof(c)} меньше или равна 0");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Некорректные параметры сторон: сумма каждых 2 сторон должна быть больше третьей");
        }

        internal override double GetSquare()
        {
            //лишние аллокации, код для тестового задания
            List<int> sides = new (){ A, B, C };
            var gip = sides.Max();
            sides.Remove(gip);
            var k1 = sides[0];
            var k2 = sides[1];

            //проверка, является ли треугольник прямоугольным
            if (Math.Pow(gip, 2) == (Math.Pow(k1, 2) + Math.Pow(k2, 2)))
            {
                return k1 * k2 / 2;
            }

            var p = (k1 + k2 + gip)/2;
            var s = Math.Sqrt(p * (p - k1) * (p - k2) * (p - gip));
            return s;
        }
    }
}
