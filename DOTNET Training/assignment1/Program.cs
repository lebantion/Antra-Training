/*
1)
Age, Salary, Price, Shipping Weight, Population, The Number of Employees
 
2) 
Boxing is implicit and Unboxing is explicit.
References store references to data
Value types directly contain data.

3)
Unmanaged source is source that not under control of garbage collector (File handles, pinned memory, COM objects, database connections etc.)
Managed source is under control.

4) Purpose of Garbage Collector is to prevent memory leak by allocated memory
*/

class Program
{
    static void Main(string[] args)
    {
        typeSize();
        stackofStars();
        centuryConvertor();
        numGuesser();
        birthDate();
        greeting();
        counting();
    }

    static void typeSize() {
        Console.WriteLine($"sbyte         | {sizeof(sbyte),-12} | {sbyte.MinValue,-24} | {sbyte.MaxValue,24}");
        Console.WriteLine($"byte          | {sizeof(byte),-12} | {byte.MinValue,-24} | {byte.MaxValue,24}");
        Console.WriteLine($"short         | {sizeof(short),-12} | {short.MinValue,-24} | {short.MaxValue,24}");
        Console.WriteLine($"ushort        | {sizeof(ushort),-12} | {ushort.MinValue,-24} | {ushort.MaxValue,24}");
        Console.WriteLine($"int           | {sizeof(int),-12} | {int.MinValue,-24} | {int.MaxValue,24}");
        Console.WriteLine($"uint          | {sizeof(uint),-12} | {uint.MinValue,-24} | {uint.MaxValue,24}");
        Console.WriteLine($"long          | {sizeof(long),-12} | {long.MinValue,-24} | {long.MaxValue,24}");
        Console.WriteLine($"ulong         | {sizeof(ulong),-12} | {ulong.MinValue,-24} | {ulong.MaxValue,24}");
        Console.WriteLine($"float         | {sizeof(float),-12} | {float.MinValue,-24} | {float.MaxValue,24}");
        Console.WriteLine($"double        | {sizeof(double),-12} | {double.MinValue,-24} | {double.MaxValue,24}");
        Console.WriteLine($"decimal       | {sizeof(decimal),-12} | {decimal.MinValue,-24} | {decimal.MaxValue,24}");
    }

    static void stackofStars()
    {
        int rows = 5;

        for (int i = 1; i <= rows; i++)
        {
            // Print spaces
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            // Print asterisks
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    static void centuryConvertor() {
        const int yearsPerCentury = 100;
        const int daysPerYear = 365;
        const int hoursPerDay = 24;
        const int minutesPerHour = 60;
        const int secondsPerMinute = 60;
        const int millisecondsPerSecond = 1000;
        const long microsecondsPerMillisecond = 1000;
        const long nanosecondsPerMicrosecond = 1000;
		

        Console.Write("Input: ");
        int centuries = int.Parse(Console.ReadLine());
		
        long years = (long)centuries * yearsPerCentury;
        long days = years * daysPerYear;
        long hours = days * hoursPerDay;
        long minutes = hours * minutesPerHour;
        long seconds = minutes * secondsPerMinute;
        long milliseconds = seconds * millisecondsPerSecond;
        long microseconds = milliseconds * microsecondsPerMillisecond;
        long nanoseconds = microseconds * nanosecondsPerMicrosecond;

		Console.WriteLine("Output: ");
        Console.WriteLine($"{centuries} centuries = ");
        Console.WriteLine($"{years} years = ");
        Console.WriteLine($"{days} days = ");
        Console.WriteLine($"{hours} hours = ");
        Console.WriteLine($"{minutes} minutes = ");
        Console.WriteLine($"{seconds} seconds = ");
        Console.WriteLine($"{milliseconds} milliseconds = ");
        Console.WriteLine($"{microseconds} microseconds = ");
        Console.WriteLine($"{nanoseconds} nanoseconds = ");
    }

    static void numGuesser()
    {
        int randomNumber = new Random().Next(3) + 1;

        Console.Write("Guess a number between 1 and 3: ");
        int input = int.Parse(Console.ReadLine());
		
        if (input < 1 || input > 3)
        {
            Console.WriteLine("Your guess is outside of range.");
        }
        else if (input == randomNumber)
        {
            Console.WriteLine("You guessed the correct number.");
        }
        else if (input < randomNumber)
        {
            Console.WriteLine("Your guess is too low.");
        }
        else // input > randomNumber
        {
            Console.WriteLine("Your guess is too high.");
        }
    }

    static void birthDate() {
        // Define birth date
        int birthYear = 1990;
        int birthMonth = 4;
        int birthDay = 19;

        // Calculate age in days
        int ageInDays = (2023 - birthYear) * 365 +
                        (4 - birthMonth) * 30 +
                        (19 - birthDay);

        Console.WriteLine($"You are {ageInDays} days old.");

        // Calculate days until next 10,000 day anniversary
        int daysToNextAnniversary = 10000 - (ageInDays % 10000);

        Console.WriteLine($"Your next 10,000 day anniversary is on {daysToNextAnniversary:d}.");
    }

    static void greeting()
    {
        DateTime now = DateTime.Now;
        int hour = now.Hour;

        if (hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        if (hour >= 12 && hour < 18)
        {
            Console.WriteLine("Good Afternoon");
        }
        if (hour >= 18 && hour < 21)
        {
            Console.WriteLine("Good Evening");
        }
        if (hour >= 21 || hour < 5)
        {
            Console.WriteLine("Good Night");
        }

        Console.ReadLine();
    }

    static void counting() {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j <= 24; j += i)
            {
		        if (j == 24) Console.Write(j);
		        else Console.Write(j + ",");
            }
            Console.WriteLine();
        }
    }

}

/*
1) Error

2) Error

3) will show minimum value of Int Type

4) x = y++; y will increase after line passed
   x = ++y; y will increase in line.

5) break will terminate loop, continue will skip to next loop, return will terminate and return the value.

6) initialization, condition, iteration

7) = is for assignment and == is for condition (equality operator);

8) it does run but it is not efficient.

9) _ is discard symbol for switch expression

10) IEnumerable

1) Infinite loop because byte's max value is 255

*/
