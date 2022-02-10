Person person1 = new Person();
Animal animal1 = new Animal();
Car car1 = new Car();

person1.person();
animal1.animal();
car1.car();

Person person = new Person();
person.IntroduceYourself();
class Person
{
    public string name;
    string[] persons = new string[3];
    public void IntroduceYourself()
    {
        for(var name = 0; name < persons.Length; name++)
        { 
            Console.WriteLine("Give me a name.");
            persons[name] = Console.ReadLine();
        }
        foreach (string value in persons)
        {
            Console.WriteLine("Hello, my name is" + name);
        }
    }
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