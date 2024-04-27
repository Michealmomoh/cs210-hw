using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine ("Enter your Grade ");
        string Letter = Console.ReadLine();
        int grade = int.Parse(Letter);
        Console.WriteLine(grade);
        string letter = "";
        if (grade >= 90)
        {
            letter = "A"; 
            Console.WriteLine("Your grade is " + letter );
            Console.WriteLine("you passes your test");
       }
        else if (grade  >= 80)
        {
            letter = "B";
            Console.WriteLine("Your grade is " + letter );
            Console.WriteLine("you passes your test");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine("Your grade is " + letter );
            Console.WriteLine("you passes your test");
        }
        else if (grade >= 60)
        {
            letter ="D";
            Console.WriteLine("your grade is " + letter);
            Console.WriteLine("you passed your test");
        }
        if (grade  <= 59)
        {
            letter = "F";
            Console.WriteLine("your grade is " + letter);
            Console.WriteLine("Better luck next time"); 

        }
        


    }
}