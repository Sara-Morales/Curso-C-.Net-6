// See https://aka.ms/new-console-template for more information

//Calcular el area de un cuadrado

string userData;
double side;
double squareArea;

Console.WriteLine("Hola, te proporcionaré el área de un cuadrado");
Console.WriteLine("__________");
Console.WriteLine("|        |");
Console.WriteLine("|        |");
Console.WriteLine("|        |");
Console.WriteLine("|        |");
Console.WriteLine("__________");
Console.WriteLine("¿Cuánto mide un lado del cuadrado?");
userData = Console.ReadLine();

if (double.TryParse(userData, out side))
{
    squareArea = side * side;
    Console.WriteLine($"El área de tu cuadrado es: {squareArea}");
}
else
{
    Console.WriteLine("Los datos proporcionados son incorrectos");
}
Console.ReadKey();