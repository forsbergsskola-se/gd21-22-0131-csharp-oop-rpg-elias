static class SuperMath
{
    static void Main()
    {
        Console.WriteLine(Lerp(0, 100, 0));
        Console.WriteLine(Lerp(0, 100, 0.1f));
        Console.WriteLine(Lerp(0, 100, 0.3f));
        Console.WriteLine(Lerp(0, 100, 0.7f));
        Console.WriteLine(Lerp(0, 100, 1.0f));
        Console.WriteLine(Lerp(0, 100, 1.3f));
        Console.WriteLine(Lerp(100, 200, 0f));
        Console.WriteLine(Lerp(100, 200, 0.1f));
        Console.WriteLine(Lerp(100, 200, 0.3f));
        Console.WriteLine(Lerp(100, 200, 0.7f));
        Console.WriteLine(Lerp(100, 200, 1.0f));
        Console.WriteLine(Lerp(100, 200, 1.3f));
        Console.WriteLine(Lerp(200, -100, 0));
        Console.WriteLine(Lerp(200, -100, 0.1f));
        Console.WriteLine(Lerp(200, -100, 0.3f));
        Console.WriteLine(Lerp(200, -100, 0.7f));
        Console.WriteLine(Lerp(200, -100, 1.0f));
        Console.WriteLine(Lerp(200, -100, 1.3f));
    }

    static float Lerp(float from, float to, float t)
    {
        float answer = from + (to - from) * t;
        Console.Write($"Lerp from {from} to {to} with t ({t}): ");
        return answer;
    }
}