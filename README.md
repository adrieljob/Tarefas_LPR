using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();
        List<string> names = new List<string>();

        Console.Write("Enter the number of names: ");
        int numNames = int.Parse(Console.ReadLine());

        for (int i = 0; i < numNames; i++)
        {
            names.Add(GenerateRandomName(random));
        }

        names.Sort((a, b) => a.Length.CompareTo(b.Length));

        int currentLength = 0;
        foreach (string name in names)
        {
            if (name.Length!= currentLength)
            {
                Console.WriteLine();
                currentLength = name.Length;
            }
            Console.Write(name + " ");
        }
    }

    static string GenerateRandomName(Random random)
    {
        int length = random.Next(3, 10); // random length between 3 and 10
        char[] chars = new char[length];
        for (int i = 0; i < length; i++)
        {
            chars[i] = (char)('a' + random.Next(26)); // random lowercase letter
        }
        return new string(chars);
    }
}
