using System;
using System.Collections.Generic;
using System.Linq;


namespace FirstCode
{
    public class Basics
    {
        public static void Main(string[] args)
        {
            string[] stringArray = new string[3];
            stringArray[0] = "Hello";
            stringArray[1] = "World";
            stringArray[2] = "! \n";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            // Dynamically increases when items are added to List
            List<string> listArray = new List<string>() { "Test1", "Test2", "Test3" };

            for (int i = 0; i < 3; i++)
            {
                if (i != 2)
                {
                    Console.WriteLine(listArray[i]);
                }
                else
                {
                    Console.WriteLine(listArray[i] + "\n");
                }
            }

            listArray.Add("Test4");
            for (int i = 0; i < 4; i++)
            {
                if (i != listArray.Count - 1) Console.WriteLine(listArray[i]);
                else Console.WriteLine(listArray[i] + "\n");
            }
            /*
             * We need to already have a list or an array that we can assign to our ienumarable
             * Not an indeaxable collection
             */
            IEnumerable<string> myIEnum = listArray;
            Console.WriteLine(myIEnum.First());
            
            // Multi dimensional, add "," 
            string[,] twoDArray = new string[,]
            {
                { "1D", "1DD", "1DDD" },
                { "2D", "2DD", "2DDD" }
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2) Console.WriteLine(twoDArray[i,j] + "\n");
                    else Console.WriteLine(twoDArray[i,j]);
                }
            }
            
            // String == key and key == value
            Dictionary<string, string[]> myDictionary = new Dictionary<string, string[]>()
            {
                { "Strings", new string[]{"first_string","second_string","third_string"} }
            };
            // Returns key  -- "Strings"
            Console.WriteLine(myDictionary["Strings"][0]); // Returns first_string


            Dictionary<string, int> dictionaryTest = new Dictionary<string, int>();
            dictionaryTest["First"] = 1;
            dictionaryTest["Second"] = 2;

            Console.WriteLine(dictionaryTest["First"]); // prints 1
            Console.WriteLine(dictionaryTest["Second"]); // prints 2
            
            
            //Appending

            string firstString = "Hello_"; 
            firstString += "World!!";
            Console.WriteLine(firstString);

            string[] test_First_String = firstString.Split("_"); // splits at _
            Console.WriteLine(test_First_String[0]);
            Console.WriteLine(test_First_String[1]);
        }
    }
}