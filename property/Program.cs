
class Person
{
    public string Name
    {
      get; set;
    }
}

class Vehicle
{
    public string brand = "Ford";
    public void honk()
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle
{
    public string modelName = "Mustang";
}


class Program
{
    static void Main(string[] args)
    {
        Person Obj = new Person();
        Obj.Name = "Masrafi";
        Console.WriteLine(Obj.Name);

        Car newCar = new Car();

        newCar.honk();

        Console.WriteLine(newCar.brand + " " + newCar.modelName);
    }
}