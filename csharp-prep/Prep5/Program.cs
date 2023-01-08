using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PrompUserName();
        int number = PrompUserNumber();

        int square = SquareNumber(number);

        DisplayResult(name, square);
        
    }    
    static void  DisplayWelcome()
    {
        Console.WriteLine("welcome to the program!");
    }
    static string PrompUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PrompUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }
    static int SquareNumber(int favoriteNumber)
    {
        int square = favoriteNumber * favoriteNumber;
        return square;
    }
    static void DisplayResult( string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
    
}