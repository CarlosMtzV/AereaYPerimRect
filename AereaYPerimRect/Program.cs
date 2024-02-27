using AereaYPerimRect;

Console.WriteLine("insert a valor");
double baze = double.Parse(Console.ReadLine());

Console.WriteLine("insert a valor");
double altu = double.Parse(Console.ReadLine());

Rectangle myRectangle = new Rectangle(baze, altu);

RectangleWithPerimeter myRectangleWithPerimeter = new RectangleWithPerimeter(baze, altu);

double area = myRectangle.CalculateArea();

double perimeter = myRectangleWithPerimeter.CalculatePerimeter();

Console.WriteLine("Area of the rectangle: " + area);
Console.WriteLine("Perimeter of the rectangle: " + perimeter);



Console.ReadKey();