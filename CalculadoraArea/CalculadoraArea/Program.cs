// See https://aka.ms/new-console-template for more information
const double PI = 3.1416;
string userData;
double radius;
double circleArea;

Console.WriteLine("Ingresa el radio del circulo: ");
userData = Console.ReadLine();

if (double.TryParse(userData, out radius))
{
    circleArea = PI * Math.Pow(radius, 2);
    Console.WriteLine($"El área de tu circulo es: {circleArea}");
}
else
{
    Console.WriteLine("Los datos proporcionados son incorrectos");
}
Console.Read();
