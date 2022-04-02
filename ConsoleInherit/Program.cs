// See https://aka.ms/new-console-template for more information

using ConsoleInherit;

Figur[] figures =
{
    new FTriangle("Треугольник", new int[]{3,2,2}),
    new FRectangle("Прямоугольник", new int[]{8,4}),
    new FSquare("Квадрат", 10)
};

foreach (var item in figures)
{
    item.Print();
}

FComposite composite = new FComposite(figures);
composite.Print();

