using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("what is your magic number? ");
        string magic_number  = Console.ReadLine();
        int magicNumber = int.Parse(magic_number);
        

        int guess = -1;

        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}