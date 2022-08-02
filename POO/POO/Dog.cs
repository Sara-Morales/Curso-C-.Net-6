// See https://aka.ms/new-console-template for more information


public class Dog
{
    //Estado u propiedades de la clase
    public string Name { get; set; }
    public string Bread { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }

    //Comportamientos, funcionalidad
    public void Bark ()
    {
        Console.WriteLine(Name + ": Guu, gua, guaa!");
    }
    public void Sleep()
    {
        Console.WriteLine(Name + ": Zzzzzzzzzzzzzz");
    }
    public void Eat()
    {
        Console.WriteLine(Name + ": Jaam, jam!");
    }
    public override string ToString()
    {
        return this.Name;
    }

}