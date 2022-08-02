// See https://aka.ms/new-console-template for more information


Dog roky = new Dog();
roky.Name = "Roky";
roky.Bread = "Chihuahua";
roky.Age = 3;
roky.Color = "cafe";
roky.Bark();
roky.Eat();
roky.Sleep();

Dog dogo = new Dog();
dogo.Name = "Dogo";
dogo.Bread = "Pastor Alemán";
dogo.Bark();
dogo.Eat();
dogo.Sleep();

Console.WriteLine(dogo.ToString());
Console.ReadKey();