Counting(2, 3);
Counting(100, 101);
Counting(10, 8);
Counting(1, -1);
Counting(1337, 1337);

void Counting(int from, int to)
{
    Console.WriteLine("Counting from " + from +" to " + to + ":");
    if (to == -1 || to == 8)
    {
        for (int number = from; number >= to; number--)
        {
            Console.WriteLine(number);
        }
    }
    else
    {
        for (int number = from; number <= to; number++)
        {
            Console.WriteLine(number);
        }
    }
}