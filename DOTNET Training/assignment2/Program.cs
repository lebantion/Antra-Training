/*
    1)
        For String, you should use it for when you dont need to change the value of String
        For StringBuilder, you should ues it for when you want to change the value of String frequently
    2)
        Its stored in System.Array
    3)
        sort()
    4)
        length property in Array Object
    5)
        Yes, you can store multiple data in array. 
        However, you need to cast it before using it but if you define array type then you dont have to
    6)
        CopyTo(), it copy entire array to new array
        Clone(), it copy the references of the array, so if you change the value in orginal array
        then it will affect cloned array.

*/

using System;
using System.Collections;

class Program
{
    // To test each method you can just call the method.
    static void Main(string[] args)
    {

    }

    static void Copyarray() 
    {
        int[] temp = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int[] temp1 = new int[10];
        int[] temp2 = new int[temp.Length];
        temp.CopyTo(temp2, 0);
        
        for ( int i = 0 ; i < temp.Length ; i++ ) 
        {
            temp1[i] = temp[i];
        }

        foreach (int x in temp1) 
        {
            Console.WriteLine("temp1: " + x);
        }

        foreach (int x in temp2) 
        {
            Console.WriteLine("temp2: " + x);
        }
    }

    static void Todolist() 
    {
        bool swCase = true;
        ArrayList todo = new ArrayList();
        while (swCase) 
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            String input = Console.ReadLine();

            if (input.StartsWith("+")) 
            {
                todo.Add(input.Substring(1).Trim());
            }
            else if(input.StartsWith("-")) {
                if (input.Substring(0,2) == "--") {
                    todo.Clear();
                }
                else {
                    if (todo.Contains(input.Substring(1).Trim()))
                    {
                        todo.Remove(input.Substring(1).Trim());
                    }
                    else 
                    {
                        Console.WriteLine("Your todo list does not have that item");
                    }
                }
            }
            else {
                Console.WriteLine("Command does not exist, error occur, terminate program");
                break;
            }

            Console.WriteLine("Current todo List :");
            foreach (String item in todo) {
                Console.WriteLine(item);
            }
        }

        
    }

    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            bool isPrime = true;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && i > 1)
            {
                primes.Add(i);
            }
        }

        return primes.ToArray();
    }


    static void SumofRotatedArray() 
    {
        int[] input = new int[5] {1, 2, 3, 4, 5};
        int rotate = 3;
        int[] sum = new int[input.Length];
        Array.Clear(sum);

        ArrayList rotatedArray = new ArrayList();
        rotatedArray.AddRange(input);

        foreach (int items in rotatedArray) {
            Console.WriteLine(items + " ");
        }

        for (int i = 0 ; i < rotate ; i++) 
        {
            int temp = (int) rotatedArray[rotatedArray.Count - 1];
            rotatedArray.RemoveAt(rotatedArray.Count - 1);
            rotatedArray.Insert(0, temp);
            for (int j = 0 ; j < rotatedArray.Count ; j++ ) {
                sum[j] += (int) rotatedArray[j];
            }
        }
        
        Console.WriteLine("result: ");
        foreach (int item in sum)
        {
            Console.WriteLine(item + " ");
        }

    }
    

    static void MostFrequentNum() 
    {
        int[] numbers = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
        Dictionary<int, int> counts = new Dictionary<int, int>();
        Dictionary<int, int> duplicatedMax = new Dictionary<int, int>();
        int maxCount = 0;
        int mostFrequent = 0;

        foreach (int number in numbers)
        {
            if (!counts.ContainsKey(number))
            {
                counts[number] = 1;
            }
            else 
            {
                counts[number]++;
            }

            if (counts[number] > maxCount)
            {
                maxCount = counts[number];
                mostFrequent = number;
            }
        }

        foreach (KeyValuePair<int, int> pair in counts) {
            if (pair.Value == maxCount) {
                duplicatedMax.Add(pair.Key, pair.Value);
            }
        }

        if (duplicatedMax.Count == 1) 
        {
            Console.WriteLine("Most Frequent Number is : " + mostFrequent + " Occured : " + maxCount);
        }
        else 
        {
            Console.Write("duplicated max count number is :");
            foreach(KeyValuePair<int, int> pair in duplicatedMax) 
            {
                Console.Write(pair.Key + " ");   
            }

            Console.WriteLine("left most is " + duplicatedMax.FirstOrDefault().Key);
        }
    }

    static void ReverseString()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] charArr = input.ToCharArray();
        Array.Reverse(charArr);
        string reversed1 = new string(charArr);

        Console.WriteLine("Reversed string 1: " + reversed1);

        string reversed2 = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed2 += input[i];
        }

        Console.WriteLine("Reversed string 2: " + reversed2);
    }

    static void ReverseSentenceWords()
    {
        string input = "C# is not C++, and PHP is not Delphi!";
        char[] separators = new char[] { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };

        string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        string[] separatorsAndSpaces = input.Split(words, StringSplitOptions.None);

        Array.Reverse(words);

        var output = words.Zip(separatorsAndSpaces, (w, s) => w + s);
        Console.WriteLine(string.Concat(output));
    }

    static void PalindromeWord() {
        Console.WriteLine("Enter some text:");
        string input = Console.ReadLine();
        char[] separators = new char[] { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };
        ArrayList palindWord = new ArrayList();

        string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
 
        Console.Write("Palindrome words are : ");
        foreach(String item in words) {
            if (item.SequenceEqual(item.Reverse())) palindWord.Add(item);
        }
        palindWord.Sort();

        foreach(String item in palindWord) {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        
    }

    static void SeparateURL() {
        Console.Write("Enter a URL: ");
        string url = Console.ReadLine();

        string protocol = "";
        string server = "";
        string resource = "";

        int protocolEnd = url.IndexOf("://");
        if (protocolEnd != -1)
        {
            protocol = url.Substring(0, protocolEnd);
            url = url.Substring(protocolEnd + 3);
        }

        int serverEnd = url.IndexOf('/');
        if (serverEnd != -1)
        {
            server = url.Substring(0, serverEnd);
            resource = url.Substring(serverEnd + 1);
        }
        else
        {
            server = url;
        }

        Console.WriteLine("Protocol: {0}", protocol);
        Console.WriteLine("Server: {0}", server);
        Console.WriteLine("Resource: {0}", resource);
    }
}