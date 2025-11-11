namespace workshop3
{
    internal class Workshop3
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.add(10, 5);
            calculator.subtract(10, 5);
            calculator.multiply(10, 5);
            calculator.divide(10, 5);
            calculator.OddEvenFinder(10);

            NullOperations nullOperations = new NullOperations();
            nullOperations.PerformNullChecks();

            Age ageChecker = new Age();
            ageChecker.checkAge();

            DayPrinter.PrintDayFromNumber();

            Loops loops = new Loops();
            loops.SumFromOneToN();
            loops.PrintNumbersWithContinueAndBreak();
            loops.SumArrayElements();

            ExceptionHandling exceptionHandling = new ExceptionHandling();
            exceptionHandling.ConvertToInteger();
            exceptionHandling.ValidatePassword();
        }
    }

    public class Calculator
    {
        // Task 1
        public void add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum: " + sum);
        }
        public void subtract(int a, int b)
        {
            int difference = a - b;
            Console.WriteLine("Difference: " + difference);
        }
        public void multiply(int a, int b)
        {
            int product = a * b;
            Console.WriteLine("Product: " + product);
        }
        public void divide(int a, int b)
        {
            if (b != 0)
            {
                int quotient = a / b;
                Console.WriteLine("Quotient: " + quotient);
            }
            else
            {
                Console.WriteLine("Error: Division by zero");
            }
        }
        public void OddEvenFinder(int number)
        {
            Console.WriteLine(number + " is " + (number % 2 == 0 ? "Even" : "Odd"));
        }
    }

    // Task 2
    public class NullOperations
    {
        public void PerformNullChecks()
        {
            string username = null;

            // using ternary operator to check for null
            Console.WriteLine(username == null ? "Username is not available" : $"Username: {username}");

            // using null-coalescing operator
            string displayName = username ?? "username is not available";
            username ??= "User";
            Console.WriteLine($"Display Name: {displayName}");
            Console.WriteLine($"Username after null-coalescing assignment: {username}");
        }
    }

    // Task 3
    public class Age
    {
        int age = Console.ReadLine() != null ? int.Parse(Console.ReadLine()) : 0;
        public void checkAge()
        {
            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Adult");
            }
        }
    }

    // Task 4
    public class DayPrinter
    {
        public static void PrintDayFromNumber()
        {
            Console.Write("Enter a number (1-7): ");
            int input = int.Parse(Console.ReadLine());
            int num = input;

            if (num < 1 || num > 7)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            switch (num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
        }
    }

    // Task 5
    public class Loops
    {
        // Sum from 1 to N using for loop
        public void SumFromOneToN()
        {
            Console.Write("Enter a number N: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum from 1 to {n}: {sum}");
        }

        // Print numbers 1 to 20 using while loop with continue and break
        public void PrintNumbersWithContinueAndBreak()
        {
            int i = 1;
            while (i <= 20)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue; // Skip multiples of 4
                }

                if (i == 15)
                {
                    break; // Stop when number is 15
                }

                Console.WriteLine(i);
                i++;
            }
        }

        // Sum of all elements in array using foreach loop
        public void SumArrayElements()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"Sum of array elements: {sum}");
        }
    }
    
        // Task 6
    public class ExceptionHandling
    {
        // Convert user input to integer with try-catch-finally
        public void ConvertToInteger()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = int.Parse(input);
                Console.WriteLine($"Converted number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        // Password validation with throw exception
        public void ValidatePassword()
        {
            try
            {
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}