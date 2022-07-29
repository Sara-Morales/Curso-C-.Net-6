// See https://aka.ms/new-console-template for more information

//HashSet no acepta objetos repetidos
Console.ForegroundColor = ConsoleColor.Red;
HashSet<string> hashSet = new HashSet<string>();
hashSet.Add("a");
hashSet.Add("b");
hashSet.Add("c");
hashSet.Add("d");
hashSet.Add("a");
foreach(var item  in hashSet)
{
    Console.WriteLine(item);
}
Console.ReadKey();

//SortedSet organiza una lista de manera ascendente
Console.ForegroundColor = ConsoleColor.Green;
SortedSet<string> sortedSet = new SortedSet<string>();
sortedSet.Add("d");
sortedSet.Add("a");
sortedSet.Add("c");
sortedSet.Add("s");
sortedSet.Add("b");
sortedSet.Add("e");
foreach (var item in sortedSet)
{
    Console.WriteLine(item);
}
Console.ReadKey();

//Dictionary es una lina de llaves/valor
Console.ForegroundColor = ConsoleColor.Yellow;
Dictionary<string, double> fruitCost = new Dictionary<string, double>();
fruitCost.Add("Mango", 5000);
fruitCost.Add("Pera", 3000);
fruitCost.Add("Manzana", 1500);
Console.WriteLine($"El mango cuesta {fruitCost["Mango"]}");
Console.ReadKey();

foreach(KeyValuePair<string, double> item in fruitCost)
{
    Console.WriteLine(item);
}
Console.ReadKey();

//SortedList es un Dictionary pero ordenado
Console.ForegroundColor = ConsoleColor.Blue;
SortedList<string, double> fruitCostSorted = new SortedList<string, double>();
fruitCostSorted.Add("Mango", 5000);
fruitCostSorted.Add("Pera", 3000);
fruitCostSorted.Add("Manzana", 1500);

foreach (var item in fruitCostSorted)
{
    Console.WriteLine(item);
}
Console.ReadKey();