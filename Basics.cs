/* namespace FirstCode;

public class Basics
{
    private readonly int publicInt = 10;
    private static int publicIntStatic = 12;

    private void TestScope()
    {
        Console.WriteLine("public" + publicInt);
    }

    // Static can only access other static things
    private static int getSum(int[] intArray)
    {
        var sum = 0;
        foreach (var ints in intArray) sum += ints;
        return sum;
    }

    public static void Main(string[] args)
    {
        var stringArray = new string[3];
        stringArray[0] = "Hello";
        stringArray[1] = "World";
        stringArray[2] = "! \n";

        for (var i = 0; i < 3; i++) Console.WriteLine(stringArray[i]);

        // Dynamically increases when items are added to List
        var listArray = new List<string> { "Test1", "Test2", "Test3" };

        for (var i = 0; i < 3; i++)
            if (i != 2)
                Console.WriteLine(listArray[i]);
            else
                Console.WriteLine(listArray[i] + "\n");

        listArray.Add("Test4");
        for (var i = 0; i < 4; i++)
            if (i != listArray.Count - 1) Console.WriteLine(listArray[i]);
            else Console.WriteLine(listArray[i] + "\n");
        /*
         * We need to already have a list or an array that we can assign to our ienumarable
         * Not an indeaxable collection
        
        IEnumerable<string> myIEnum = listArray;
        Console.WriteLine(myIEnum.First());

        // Multi dimensional, add "," 
        string[,] twoDArray =
        {
            { "1D", "1DD", "1DDD" },
            { "2D", "2DD", "2DDD" }
        };
        for (var i = 0; i < 2; i++)
        for (var j = 0; j < 3; j++)
            if (j == 2) Console.WriteLine(twoDArray[i, j] + "\n");
            else Console.WriteLine(twoDArray[i, j]);

        // String == key and key == value
        var myDictionary = new Dictionary<string, string[]>
        {
            { "Strings", new[] { "first_string", "second_string", "third_string" } }
        };
        // Returns key  -- "Strings"
        Console.WriteLine(myDictionary["Strings"][0]); // Returns first_string


        var dictionaryTest = new Dictionary<string, int>();
        dictionaryTest["First"] = 1;
        dictionaryTest["Second"] = 2;

        Console.WriteLine(dictionaryTest["First"]); // prints 1
        Console.WriteLine(dictionaryTest["Second"]); // prints 2


        //Appending

        var firstString = "Hello_";
        firstString += "World!!";
        Console.WriteLine(firstString);

        var test_First_String = firstString.Split("_"); // splits at _
        Console.WriteLine(test_First_String[0]);
        Console.WriteLine(test_First_String[1]);


        var myFirstValueString = "some words";
        var mySecondValueString = "Some Words";

        if (myFirstValueString == mySecondValueString) Console.WriteLine("equal");
        else if (myFirstValueString == mySecondValueString.ToLower()) Console.WriteLine("equal");
        else Console.WriteLine("not equal");

        switch (myFirstValueString)
        {
            case "some words":
                Console.WriteLine("lowercase");
                break;
            case "Some":
                Console.WriteLine("Uppercase");
                break;
            default:
                Console.WriteLine("Default");
                break;
        }

        // the foreach loop iterates through each element in myNumberList,
        // and the variable number represents the current element. 
        var myNumberList = new List<int>
        {
            2, 3, 5, 6, 7, 9, 10, 123, 324, 54
        };

        foreach (var number in myNumberList)
            if (number % 2 == 0)
                Console.WriteLine(number);


        int[] intArray = { 1, 2, 3, 10, 15, 20, 30 };
        var sum = 0;
        for (var i = 0; i < intArray.Length; i++) sum += intArray[i];
        Console.WriteLine("sum:" + sum);


        sum = 0;

        // Difference: Does first, then check while, "while" checks then does whatever
        do
        {
            sum += 10;
            Console.WriteLine("sum in while" + sum);
        } while (sum < 100);


        // .Sum
        sum = 0;
        sum = intArray.Sum();
        Console.WriteLine("sum.Sum():" + sum);

        // one more
        sum = 0;

        Console.WriteLine("fastest console.Sum():" + intArray.Sum());
        sum = 0;
        sum = getSum(intArray);
        Console.WriteLine("getSum():" + sum);
    }
}
*/