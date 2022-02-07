Person person1 = new Person();
Animal animal1 = new Animal();
Car car1 = new Car();

person1.Head();
animal1.Paw();
car1.Tires();

class Person
{
    public void Head()
    {
        Console.WriteLine("Person");
    }
}

class Animal
{
    public void Paw()
    {
        Console.WriteLine("Animal");
    }
}

class Car
{
    public void Tires()
    {
        Console.WriteLine("Car");
    }
}