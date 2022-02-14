static class Program
{
    static void Main()
    {
        unit leet = new unit("Leet", 1337);
        unit zombie = new unit("Zombie", 123);
        unit skeleton = new unit("Skeleton", 111);
        unit ogre = new unit("Ogre", 100);

        while (leet.Health > 0)
        {
            Console.WriteLine("What do you want Leets health to be?");
            leet.Health = int.Parse(Console.ReadLine());
        }

        leet.Health += 50;
    }
}

public class unit
{
    public string name { get; }
    public int id;
    public static int nextId;

    private int maxHealth;
    private int health;
    
    public unit(string name, int maxHealth)
    {
        name = name;
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