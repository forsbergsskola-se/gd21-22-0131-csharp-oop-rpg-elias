static class Program
{
    static void Main()
    {
        unit zombie = new unit("Zombie", 123);
        unit skeleton = new unit("Skeleton", 111);
        unit ogre = new unit("Ogre", 100);

        zombie.name = "Eva";
    }
}

public class unit
{
    public string name;
    public int id;
    public static int nextId;

    private int maxHealth;
    private int health;
    
    public unit(string name, int maxHealth)
    {
        this.name = name;
        id = nextId++;

        this.maxHealth = maxHealth;
        this.health = maxHealth;
        
        ReportStatus();
    }

    public void SetHealth(int newHealth)
    {
        health = Math.Clamp(newHealth, 0, maxHealth);
        ReportStatus();
    }

    public void GetHealth()
    {
        return health;
    }
    public void ReportStatus()
    {
        Console.WriteLine($"unit #{id}: {name} - {health}/{maxHealth} Health");
    }
}