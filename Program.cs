/*
Code challenge Solutions
*/

class Program
{
    public static void Main()
    {
        try
        {
           // MaximumProfit();
           TotalProfit();
        }
        catch (FormatException fx)
        {
            Console.WriteLine($"An error Occured {fx.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error Occured {ex.Message}");
        }
    }
    public static void MaximumProfit()
    {
        // Finding the maximum profit you can achieve
        /*
        Time Complexity: o(n)
        */
        int maximumProfit = 0;
        var pricesArray = ArrayInput();
        for (int j = 0; j < pricesArray.Length - 1; j++)
        {
            if (pricesArray[j] < pricesArray[j + 1])
            {
                maximumProfit += pricesArray[j + 1] - pricesArray[j];
            }
        }
        Console.WriteLine("Maximum profit is: " + maximumProfit);


    }
    public static void TotalProfit()
    {
        var pricesArray = ArrayInput();
        int firstDay = pricesArray[0];
        int lastDay = pricesArray[^1];
        int result = lastDay - firstDay;
        if (result > 0)
        {
            Console.WriteLine("Total Profit is {0}", result);
            return;
        }
        Console.WriteLine("Total Profit is 0");
    }
    public static int[] ArrayInput()
    {
        var element = true;
        Console.Write("What is the number of elements: ");
        var n = int.TryParse(Console.ReadLine()!, out int number);
        var pricesArray = new int[number];
        /*
        Time Complexity: o(n^2)
        */
        for (int i = 0; i < number; i++)
        {
            do
            {
                Console.Write("What is the element: ");
                element = int.TryParse(Console.ReadLine()!, out int ele);
                if (!element)
                {
                    Console.WriteLine("Not the correct Format");
                }
                pricesArray[i] = ele;
            } while (!element);
        }
        return pricesArray;
    }
}