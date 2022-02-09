Person person1 = new Person();
Animal animal1 = new Animal();
Car car1 = new Car();

person1.person();
animal1.animal();
car1.car();

class Person
{
    public void person()
    {
        Console.WriteLine("Person");
    }
}

class Animal
{
    public void animal()
    {
        Console.WriteLine("Animal");
    }
}

class Car
{
    public void car()
    {
        Console.WriteLine("Car");
    }
}