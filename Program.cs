/*
*/

class Program
{
    public static void Main()
    {
        try
        {
            MaximumProfit();
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
        var element = true;
        int maximumProfit = 0;
        Console.Write("What is the number of elements: ");
        var n = int.TryParse(Console.ReadLine()!, out int number);
        var pricesArray = new int[number];
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
        for (int j = 0; j < pricesArray.Length - 1; j++)
        {
            if (pricesArray[j] < pricesArray[j + 1])
            {
                maximumProfit += pricesArray[j + 1] - pricesArray[j];
            }
        }
        Console.WriteLine("Maximum profit is: " + maximumProfit);


    }
}