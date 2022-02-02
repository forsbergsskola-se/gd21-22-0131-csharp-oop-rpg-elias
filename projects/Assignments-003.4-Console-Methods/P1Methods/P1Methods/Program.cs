CountUp(1);
CountDown(1);
CountUp(2);
CountDown(2);
CountUp(3);
CountDown(3);

void CountUp(int to)
{
    Console.WriteLine("Counting from 0 to " + to + ":" );
    for (int number = 0; number <= to; number++)
    {
        Console.WriteLine(number);
    }
}

void CountDown(int from)
{
    Console.WriteLine("Counting from " + from +" to 0:" );
    for (int number = from; number >= 0; number--)
    {
        Console.WriteLine(number);
    }
}