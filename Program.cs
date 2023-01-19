// using System;

namespace practice;

class Program
{
    public bool isPrime(int n)
    {
        if (n > 1)
        {
            for (var i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
        }
        return true;
    }

    public int lcm(List<int> arr)
    {
        arr.Sort();
        var range = new List<int> { };
        for (var i = arr[0]; i <= arr[1]; i++)
        {
            range.Add(i);
        }

        int count = range[range.Count - 1];
        while (!range.All(val => count % val == 0))
        {
            count++;
        }
        return count;
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        var primes = new List<int> { };

        for (var i = 2; i <= 3; i++)
        {
            if (p.isPrime(i))
            {
                primes.Add(i);
            }
        }
        // foreach (var j in primes)
        //     Console.WriteLine($"{j}");

        var a = new List<int> { 13, 1 };
        Console.WriteLine($"{p.lcm(a)}");
    }
}