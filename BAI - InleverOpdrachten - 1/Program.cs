// See https://aka.ms/new-console-template for more information

// Opg1FilterList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 1, 2 });
foreach (var i in Opg3RandomNumbers(5, 20, 7))
{
    Console.WriteLine(i);
}

static void Opg1FilterList(List<int> lijst)
{

    Dictionary<int, int> NumberAmounts = Opg1ReturnDictionaryAmounts(new Dictionary<int, int>(), lijst, 0);


    foreach (var i in NumberAmounts)
    {
        Console.WriteLine(i);
    }
    // List<int> FilteredList = Opg1ReturnFilteredList(lijst, NumberAmounts, 0);
    List<int> FilteredList = Opg1ReturnFilteredList(lijst, NumberAmounts, 0);


    foreach (int i in FilteredList)
    {
        Console.WriteLine(i);
    }


}

/// <summary>
/// Creates a Dictionary that has the number as the key and the amount of times it appears as the value
/// </summary>
static Dictionary<int, int> Opg1ReturnDictionaryAmounts(Dictionary<int, int> dictionary, List<int> lijst, int index)
{
    if (index < lijst.Count)
    {
        Opg1ReturnDictionaryAmounts(dictionary, lijst, index + 1);
        if (dictionary.ContainsKey(lijst[index]))
        {
            dictionary[lijst[index]]++;
        }
        else
        {
            dictionary.Add(lijst[index], 1);
        }
    }
    return dictionary;
}


/// <summary>
/// Filters out the numbers that only appear in the list once
/// </summary>
static List<int> Opg1ReturnFilteredList(List<int> lijst, Dictionary<int, int> dictionary, int index)
{
    if (index < lijst.Count)
    {
        if (dictionary[lijst[index]] <= 1)
        {
            lijst.Remove(index);
            lijst = Opg1ReturnFilteredList(lijst, dictionary, index + 1);
            return lijst;
        }
        else
        {
            lijst = Opg1ReturnFilteredList(lijst, dictionary, index + 1);
            return lijst;
        }
    }
    else
    {
        return lijst;
    }
}

static Stack<int> Opg3RandomNumbers(int lower, int upper, int count)
{
    if (count < (upper - lower))
    {
        Random rand = new Random();
        Dictionary<int, int> uniqueNumberChecker = new Dictionary<int, int>();
        Stack<int> randomUniqueNumbers = new Stack<int>();
        int generatedNumber;
        for (int i = 0; i < count; i++)
        {
            generatedNumber = rand.Next(lower, upper);
            while (uniqueNumberChecker.ContainsKey(generatedNumber))
            {
                generatedNumber = rand.Next(lower, upper);
            }
            randomUniqueNumbers.Push(generatedNumber);
            uniqueNumberChecker.Add(generatedNumber, 1);
        }


        return randomUniqueNumbers; // done to remover the error for now
    } else
    {
        Console.WriteLine("Count is more than (Upper - Lower), can't generate a Stack");
        return null; 
    }
}