static class Program
{
    static void Main()
    {
        Unit leet = new Unit("Leet", 1337);
        Unit zombie = new Unit("Zombie", 123);
        Unit skeleton = new Unit("Skeleton", 111);
        Unit ogre = new Unit("Ogre", 100);

        while (leet.Health > 0)
        {
            Console.WriteLine("What do you want Leets health to be?");
            leet.Health = int.Parse(Console.ReadLine());
        }

        leet.Health += 50;
    }
}

public class Unit
{
    public string name;
    public int id;
    public static int nextId;

    private int maxHealth;
    private int health;
    
    public Unit(string name, int maxHealth)
    {
        this.name = name;
        id = nextId++;

        this.maxHealth = maxHealth;
        this.health = maxHealth;
        
        ReportStatus();
    }

    public int Health
    {
        set
        {
            health = Math.Clamp(value, 0, maxHealth);
            ReportStatus();
        }
        get
        {
            return health;
        }
    }

    public void ReportStatus()
    {
        Console.WriteLine($"unit #{id}: {name} - {health}/{maxHealth} Health");
    }
}