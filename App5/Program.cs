using System;

public class App5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe");
        string number = Console.ReadLine();

        int[] digits = new int[10];

        foreach (char c in number)
        {
            if(char.IsDigit(c))
            {
                int letter = int.Parse(c.ToString());
                digits[letter]++;

            }
        }
        for (int i = 0;i<10;i++)
        {
            if (digits[i] > 0)
            {
                Console.WriteLine($"Liczba cyfr{i}: {digits[i]}");
            }
        }
    }
}