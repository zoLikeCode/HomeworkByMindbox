namespace HomeworkByMindbox.lab
{
    public class Figure
    {
        // Функция для реализации принципа Открытости/Закрытости(SOLID)
        public static double FigureArea(IFigure figure)
        {
            return figure.FigureArea();
        }

        // Формула площади круга по радиусу
        public static double CircleArea(double r)
        {
            double pi = Math.Round(Math.PI, 2);
            double s = pi * r * r;
            return Math.Round(s, 2);
        }

        // Формула Герона для площади треугольника по трем сторонам
        public static double TriangleArea(double a, double b, double c)
        {
            double perimeter = (a + b + c) / 2;
            double s = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
            return Math.Round(s, 2);
        }

        //Проверка на прямоугольный треугольник
        public static bool RightAngledTriangle(double a, double b, double c)
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                return true;
            }
            return false;
        }

    }

    public interface IFigure
    {
        double FigureArea();
    }

    //Добавление новой фигуры квадрат
    class SquareFigure : IFigure
    {
        private double _a;
        private double _b;

        public SquareFigure(double a, double b)
        {
            _a = a;
            _b = b;
        }
        public double FigureArea()
        {
            return Math.Round(_a * _b, 2);
        }
    }
}
