public class Challenge_one
{
    public void PrintNumbers(int start, int end)
    {
        // Todo: Print out the numbers 1 - 10
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void PrintStrings(string[] arr)
    {
        /* Todo: Print out each string that is passed to the array as an argument*/
        foreach (string str in arr)
        {
            Console.WriteLine(str);
        }
    }

    public void CheckIfNumberIsPositiveOrNegative(int number)
    {
        /*
        Todo: Check if a number is positive, negative or zero.
        */
        if (number > 0)
        {
            Console.WriteLine($"{number} is positive!");
        }
        else if (number < 0)
        {
            Console.WriteLine($"{number} is negative!");
        }
        else
        {
            Console.WriteLine($"{number} is zero!");
        }
    }


}