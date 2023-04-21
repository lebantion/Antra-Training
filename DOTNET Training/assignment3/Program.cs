/*
1)

public: The member can be accessed from any code.
private: The member can only be accessed from within the same class.
protected: The member can be accessed from within the same class or any derived class.
internal: The member can be accessed from any code within the same assembly.
protected internal: The member can be accessed from any code within the same assembly or any derived class, even if it is in another assembly.
private protected: The member can be accessed from within the same class or any derived class that is within the same assembly.

2)
static keyword indicates that a member belongs to the type itself
const keyword indicates that a member cannot be changed after it is initialized
readonly keyword indicates that a member can only be assigned a value in the constructor or at declaration

3) It initializes the object's data and prepares it for use.

4) partial keyword allows a class, struct, or interface to be defined in multiple files.

5) A tuple is a lightweight data structure that allows you to group together multiple values of different types.

6) record keyword is used to define a data type that represents an immutable set of data values.

7)
Overloading : same method but different parameters and different implementation
Overriding : getting method from derived class and customize it. 

8)

A field is a data member of a class that stores a value
A property is a special kind of member that provides access to a private field, 

9) You can make a method parameter optional by giving it a default value.

10) interface is a type that defines a set of related methods, properties, and events that can be implemented by any class or struct.

11) All members of an interface in C# are implicitly public and abstract. 

12) True 
13) True 
14) False 
15) False 
16) True 
17) True 
18) True
19) True
20) False
21) True
22) False
23) True
*/

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateNumber();

        Reverse(numbers);

        PrintNumbers(numbers);

        Console.WriteLine(Fibonacci(8));
    }

    static void Reverse(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }
    }

    static int[] GenerateNumber() 
    {
        Console.WriteLine("Please input length of the array");
        int length = Int32.Parse(Console.ReadLine());

        int[] result = new int[length];

        for (int i = 0 ; i < length ; i++)
        {
            result[i] = i + 1;
        }

        return result;
    }

    static void PrintNumbers(int[] arr) {
        foreach(int item in arr)
        {
            Console.WriteLine(item + " ");
        }
    }
    
    public static int Fibonacci(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
