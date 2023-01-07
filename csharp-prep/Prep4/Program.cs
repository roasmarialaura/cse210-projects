using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number:");
            number = int.Parse(Console.ReadLine());

            if (number!= 0)
            {
                numbers.Add(number);
            }
            

        }
        //Core requeriment 1
        float sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"The sum is {sum}");
        //Core requeriment 2
        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Core requeriment 3
        int maximun = numbers[0];
         foreach (int num in numbers)
        {
            if (num > maximun)
            {
                maximun = num;
            }
        }
        Console.WriteLine($"The maximun number is: {maximun}");

        
    }
}