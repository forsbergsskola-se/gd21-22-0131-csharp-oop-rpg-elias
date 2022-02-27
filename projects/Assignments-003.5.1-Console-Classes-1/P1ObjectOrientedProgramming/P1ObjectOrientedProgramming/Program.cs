    string[] names = new string[3];
    for (int i = 0; i < names.Length; i++)
    {
        Console.WriteLine("Give me a name.");
        if (i == 0)
        {
            names[0] = Console.ReadLine();
        }
        else if (i == 1)
        {
            names[1] = Console.ReadLine();
        }
        else if (i == 2)
        {
            names[2] = Console.ReadLine();
        }
    }

    for (int i = 0; i < names.Length - 1; i++)
    {
        Console.Write(names[i]);
        Console.Write(",");
    }
    Console.Write(names[names.Length-1]);