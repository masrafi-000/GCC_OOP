using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input    = Console.ReadLine().Split();
        int[] arr = new int[n];

        for(int i = 0; i<n ; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach(int num in arr)
        {
            freq[num] = freq.GetValueOrDefault(num) +1;
        }

        foreach(var items in freq)
        {
            Console.WriteLine($"{items.Key} -> {items.Value}");
        }

    }
}