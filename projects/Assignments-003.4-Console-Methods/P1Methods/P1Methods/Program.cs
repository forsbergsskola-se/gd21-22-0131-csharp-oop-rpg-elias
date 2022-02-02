CountUp();
CountDown();
CountUp();
CountDown();

void CountUp()
{
    Console.WriteLine("Counting from 0 to 5:");
    for (int number = 0; number <= 5; number++)
    {
        Console.WriteLine(number);
    }
}

void CountDown()
{
    Console.WriteLine("Counting from 5 to 0:");
    for (int number = 5; number >= 0; number--)
    {
        Console.WriteLine(number);
    }
}