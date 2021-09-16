using System;

class Program
{
    static string currentRoom = "entrance";

    public static void Main()
    {
        while (true)
        {
            if (currentRoom == "entrance")
            {
                ShowEntrance();
            }
            else if (currentRoom == "ex1")
            {
                ShowExhibitionroom1();
            }
        }
    }

    static void ShowExhibitionroom1()
    {
        Console.Clear();
        Console.WriteLine("You are in the Exhibitionroom 1\n");
        Console.WriteLine("[A] Go to Entrance");
        Console.WriteLine("[1] Look at sculpture");
        char choice = GetChoice();

        if (choice == 'a')
        {
            currentRoom = "entrance";
        }
        else if (choice == '1')
        {
            Console.WriteLine("What a marvellous sculpture!");
            Console.ReadKey(true);
        }
        else CheckForExit(choice);
    }

    static void ShowEntrance()
    {
        Console.WriteLine("You are in the entrance\n");
        Console.WriteLine("[A] Go to Exhibitionhall 1");
        Console.WriteLine("[X] Leave museum");
        char choice = GetChoice();

        if (choice == 'a')
        {
            currentRoom = "ex1";
        }
        else CheckForExit(choice);
    }

    static void CheckForExit(char choice)
    {
        if (choice == 'x') Environment.Exit(0);
    }

    static char GetChoice()
    {
        return char.ToLower(Console.ReadKey(true).KeyChar);
    }
}
