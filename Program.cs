﻿/*
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
    public static bool CanJump(int[] nums)
    {
        /*
        Time Complexity: o(n)
        Space Complexity: o(n)
        */
        int lastPosition = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= lastPosition)
            {
                lastPosition = i;
            }
        }
        return lastPosition == 0;
    }
    public static void LongestPalindrome(string word)
    {
        int length = word.Length;
        // All subStrings of length 1
        // are palindromes
        int maxLength = 1;
        int  start = 0;
        // using nested for loops to mark start and end index
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i; j < word.Length; j++)
            {
                int flag = 1;

                // Check palindrome
                for (int k = 0; k < (j - i + 1) / 2; k++)
                    if (word[i + k] != word[j - k])
                        flag = 0;

                // Palindrome
                if (flag != 0 && (j - i + 1) > maxLength)
                {
                    start = i;
                    maxLength = j - i + 1;
                }
            }
        }
        Console.Write("Longest palindrome substring is: ");
        PrintSubStr(word, start, start + maxLength - 1);
    }

    private static void PrintSubStr(string word, int start, int v)
    {
        for (int i = start; i < v; i++)
        {
            Console.WriteLine(word[i]);
            
        }
    }

    public static bool IsValid(string parentheses)
    {
        /*
        Time Complexity: o(n)
        Space Complexity: o(n)
        */
        Stack<char> stack = new();

        Dictionary<char, char> dict = new(){
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

        for (int i = 0; i < parentheses.Length; i++)
        {
            if (dict.Keys.Contains(parentheses[i]))
                stack.Push(parentheses[i]);
            else if (stack.Count > 0 && parentheses[i] == dict[stack.Peek()])
                stack.Pop();
            else
                return false;
        }

        return stack.Count == 0;
    }
}