using HomeworkByMindbox.lab;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Figure.CircleArea(3.0));
        Console.WriteLine(Figure.TriangleArea(3.0, 4.0, 5.0));
        var figure = Figure.FigureArea(new SquareFigure(2, 2));
        Console.WriteLine(figure);
        Console.WriteLine(Figure.RightAngledTriangle(4.0, 5.0, 3.0));
        Console.WriteLine("_________________________________________");

        //Выполнение compile-time
        var new_figure = new SquareFigure(2, 2);
        Console.WriteLine(new_figure.FigureArea());
    }
}
