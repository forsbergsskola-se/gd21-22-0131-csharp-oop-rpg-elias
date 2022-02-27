

int[] array = new int[11];
Random random = new Random();

Console.WriteLine("I will roll 10.000 numbers between 0 and 10");

for (int i = 0; i <= 10000; i++)
{
    int randomNum = random.Next(0, 11);
    array[randomNum]++;
}

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"I Rolled {i} a total time of {array[i]} times");   
}


