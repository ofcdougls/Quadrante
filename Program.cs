double x, y;
string local = "";

Console.WriteLine("--- Cartesian quadrant ---/");

Console.WriteLine("Enter the desired point");

Console.Write("X-coordinate: ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Y-coordinate: ");
y = Convert.ToDouble(Console.ReadLine());

if (x == 0 && y == 0) local = "The origin";
else if (x == 0) local = "The axis of ordinates";
else if (y == 0) local = "The axis of abscissas";
else if (y > 0)
{
    if (x > 0)
        local = "quadrant 1";
    else if (x < 0)
        local = "quadrant 2";
}
else
{
    if (x < 0 && y>0)
        local = "quadrant 3";
    else if (y<0)
        local = "quadrant 4";
}
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"\nO point ({x}, {y}) is n{local}.");
Console.ResetColor();
