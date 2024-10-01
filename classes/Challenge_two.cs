public class Challenge_two
{
    public void GuessNumber()
    {
        int? secret = 9; // Assign the secret value
        int? guess = 0;
        while (guess != secret)
        {
            Console.WriteLine("Guess the secret number: ");
            try
            {
                guess = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
                continue; 
            }
            
            if (guess == secret)
            {
                Console.WriteLine($"Your guess was: {guess}, \nThe answer is: {secret} Congrats! ");
            }
            else
            {
                Console.WriteLine($"Your guess was: {guess}, \nBetter luck next time! ");
            }
        }
    }

    public void Fibonacci(int n)
    {
        int a = 0, b = 1, c;
        Console.WriteLine($"{a} + {b} + ");
        if (n >= 1)
        {
            Console.WriteLine($"{a}"); // Prints out 0
        }

        if (n >= 2)
        {
            Console.WriteLine($"{b}"); // Prints out 1
        }

        for (int i = 3; i <= n; i++)
        {
            c = a + b; // Showcasing the next number
            Console.WriteLine($"{c}"); // Prints the next number
            a = b; // Update B to the last number
            b = c; // Update A to the new number
        }
    }

    public void CheckIfNumberIsEvenOrOdd(double a, double b)
    {
        int wholeA = (int)a; // Convert double a to int
        if (wholeA % 2 == 0) // Checks if wholeA is even or odd
        {
            Console.WriteLine($"{wholeA} (from{a}) is even.");
        }
        else
        {
            Console.WriteLine($"{wholeA} (from{a}) is odd.");
        }

        int wholeB = (int)b;// Convert double b to int
        if (wholeB % 2 == 0) // Checks if wholeB is even or odd
        {
            Console.WriteLine($"{wholeB} (from{b}) is even.");
        }
            else
        {
            Console.WriteLine($"{wholeB} (from{b}) is odd.");
        }
    }
}