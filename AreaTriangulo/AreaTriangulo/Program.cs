// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hola, te proporcionaré el area de un triangulo");
Console.WriteLine(@"  /\");
Console.WriteLine(@" /  \");
Console.WriteLine(@"/    \");
Console.WriteLine("------");
double baseTriangulo;
string userDataBase;
string userDataAlt;
double AlturaTriangulo;
double areaTringulo;
Console.WriteLine("Ingresa la base del triangulo");
userDataBase = Console.ReadLine();
Console.WriteLine("ingresa la altura del triangulo");
userDataAlt= Console.ReadLine();

if (double.TryParse(userDataBase, out baseTriangulo) && double.TryParse(userDataAlt, out AlturaTriangulo))
{
    areaTringulo = (baseTriangulo * AlturaTriangulo) / 2;
    Console.WriteLine($"El área de tu triangulo es: {areaTringulo}");
}
else
{
    Console.WriteLine("Los datos proporcionados son incorrectos");
}