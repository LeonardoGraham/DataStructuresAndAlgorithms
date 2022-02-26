// 8-1
{
    var array1 = new [] {1, 2, 3, 4, 5};
    var array2 = new [] {0, 2, 4, 6, 8};
    var chapter8Exercise1 = Exercises.Intersection(array1, array2);

    Console.WriteLine("Chapter 8 Exercise 1:");
    foreach (var value in chapter8Exercise1)
    {
        Console.Write(value + " ");
    }
    Console.WriteLine("\n");
}

//8-2
{
    var array = new [] {"a", "b", "c", "d", "c", "e", "f"};
    var chapter8Exercise2 = Exercises.FindFirstDuplicate(array);

    Console.WriteLine("Chapter 8 Exercise 2:");
    Console.WriteLine(chapter8Exercise2);
    Console.WriteLine();
}

// 8-3
{
    var someString = "the quick brown box jumps over a lazy dog";
    var chapter8Exercise3 = Exercises.FindMissingChar(someString);

    Console.WriteLine("Chapter 8 Exercise 3:");
    Console.WriteLine(chapter8Exercise3);
    Console.WriteLine();
}

// 8-4
{
    var someString = "minimum";
    var chapter8Exercise4 = Exercises.FindFirstNonDuplicateChar(someString);

    Console.WriteLine("Chapter 8 Exercise 4:");
    Console.WriteLine(chapter8Exercise4);
    Console.WriteLine();
}

public static class Exercises
{
    // Chapter 8
    // 8-1
    public static IEnumerable<T> Intersection<T>(T[] array1, T[] array2) where T : struct
    {
        var intersection = new List<T>();
        var dictionary = new Dictionary<T, bool>();

        foreach (var value in array1)
        {
            dictionary[value] = true;
        }

        foreach (var value in array2)
        {
            if (dictionary.ContainsKey(value))
            {
                intersection.Add(value);
            }
        }

        return intersection;
    }
    
    // 8-2
    public static string FindFirstDuplicate(string[] array)
    {
        var dict = new Dictionary<string, bool>();

        foreach (var value in array)
        {
            if (dict.ContainsKey(value))
                return value;

            dict[value] = true;
        }

        return string.Empty;
    }
    
    // 8-3
    public static char FindMissingChar(string someString)
    {
        var dict = new Dictionary<char, bool>();

        foreach (var character in someString)
        {
            dict[character] = true;
        }

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (!dict.ContainsKey(c)) return c;
        }

        return default;
    }
    
    // 8-4
    public static char FindFirstNonDuplicateChar(string someString)
    {
        var dict = new Dictionary<char, int>();

        foreach (var character in someString)
        {
            if (dict.ContainsKey(character))
                dict[character]++;
            else
                dict[character] = 1;
        }

        foreach (var character in someString)
        {
            if (dict[character] == 1)
                return character;
        }

        return default;
    }
}