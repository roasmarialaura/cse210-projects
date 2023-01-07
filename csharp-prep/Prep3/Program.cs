using System;

class Program
{
    static void Main(string[] args)
    {   
         //Step 1 and 2
        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        //int number = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int counter = 0;

        while (randomNumber != guess)
        {
            //This part is for step 1 too
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (randomNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (randomNumber < guess)
            {
             Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            counter += 1;
        } 

        Console.WriteLine($"You tried {counter} times"); 
    }
}