// // 1. Iterate and print values

List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };


static void PrintList(List<string> MyList)
{
    foreach (string item in MyList)
    {
        Console.WriteLine(item);
    }
}
PrintList(TestStringList);


// // 2. Print Sum
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };

static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int num in IntList)
    {
        sum += num;
    }
    Console.WriteLine("Sum of numbers: " + sum);
}

// You should get back 33 in this example
SumOfNumbers(TestIntList);

// // 3. Find Max

List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
int max = FindMax(TestIntList2);
Console.WriteLine("Maximum value: " + max);


static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    foreach (int num in IntList)
    {
        if (num > max)
        {
            max = num;
        }
    }

    return max;
}


// You should get back 17 in this example
FindMax(TestIntList2);


// // 4. Square the Values

List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
List<int> squaredList = SquareValues(TestIntList3);
{

    Console.WriteLine("Squared Values: " + string.Join(",", squaredList));
}

static List<int> SquareValues(List<int> IntList)
{
    List<int> squaredValues = new List<int>();

    foreach (int num in IntList)
    {
        squaredValues.Add(num * num); // Square each value and add it to the new list
    }

    return squaredValues;
}

SquareValues(TestIntList3);

// // 5. Replace Negative Numbers with 0

int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
int[] result = NonNegatives(TestIntArray);
{
    Console.WriteLine("Modified Array: [" + string.Join(",", result) + "]");
}

static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }

    return IntArray;
}




// // 6. Print Dictionary

Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");

PrintDictionary(TestDict);


static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (var n in MyDictionary)
    {
        Console.WriteLine($"{n.Key}: {n.Value}");
    }
}



// // 7. Find Key

Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");

static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    return MyDictionary.ContainsKey(SearchTerm);
}

Console.WriteLine(FindKey(TestDict, "RealName"));

Console.WriteLine(FindKey(TestDict, "Name"));


// 8. Generate a Dictionary


List<string> names = new List<string> { "Julie", "Harold", "James", "Monica" };

List<int> numbers = new List<int> { 6, 12, 7, 10 };


Dictionary<string, int> result = GenerateDictionary(names, numbers);


foreach (var k in result)
{
    Console.WriteLine($"\"{k.Key}\": {k.Value}");
}


static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    if (Names.Count != Numbers.Count)
    {

    }

    Dictionary<string, int> dictionary = new Dictionary<string, int>();

    for (int i = 0; i < Names.Count; i++)
    {
        dictionary.Add(Names[i], Numbers[i]);
    }

    return dictionary;
}




