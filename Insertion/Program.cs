using System;
using System.Collections.Generic;

public class Pair
{
    public int Key;
    public string Value;

    public Pair(int key, string value)
    {
        Key = key;
        Value = value;
    }

    public override string ToString()
    {
        return $"({Key}, \"{Value}\")";
    }
}

public class Solution
{
    public List<List<Pair>> InsertionSort(List<Pair> pairs)
    {
        int n = pairs.Count;
        List<List<Pair>> res = new List<List<Pair>>();

        for (int i = 0; i < n; i++)
        {
            int j = i - 1;


            while (j >= 0 && pairs[j].Key > pairs[j + 1].Key)
            {
                Pair temp = pairs[j];
                pairs[j] = pairs[j + 1];
                pairs[j + 1] = temp;
                j--;
            }


            List<Pair> cloneList = new List<Pair>(pairs);
            res.Add(cloneList);
        }
        return res;
    }
}

class Program
{
    static void Main()
    {
        List<Pair> pairs1 = new List<Pair>
        {
            new Pair(5, "apple"),
            new Pair(2, "banana"),
            new Pair(9, "cherry")
        };

        List<Pair> pairs2 = new List<Pair>
        {
            new Pair(3, "cat"),
            new Pair(3, "bird"),
            new Pair(2, "dog")
        };

        Solution solution = new Solution();

        List<List<Pair>> result1 = solution.InsertionSort(pairs1);
        List<List<Pair>> result2 = solution.InsertionSort(pairs2);

        Console.WriteLine("Example 1:");
        foreach (var state in result1)
        {
            Console.WriteLine(string.Join(", ", state));
        }

        Console.WriteLine("\nExample 2:");
        foreach (var state in result2)
        {
            Console.WriteLine(string.Join(", ", state));
        }
    }
}