using System;
using ToDoList.Models;
using System.Collections.Generic;

public class Program
{
    private static List<Item> userList = new List<Item>{};
    public static void Main()
    {
        Console.WriteLine($"~~~ You have {userList.Count} items in you List ~~~");
        string response = AskView_Add();
        int caseNum = ReadResponse(response);
        switch (caseNum)
        {
            case 1:
                Console.WriteLine("Enter your task description: ");
                string description = Console.ReadLine();
                Item i = new Item(description);
                userList.Add(i);
                break;
            case 2:
                Console.WriteLine("--------------------");
                Console.WriteLine("Your To Do List:");
                Console.WriteLine("--------------------");
                foreach(Item currentItem in userList)
                {
                    Console.WriteLine($"{currentItem.Description}");
                }
                Console.WriteLine("--------------------");
                break;
            default:
                Console.WriteLine("Sorry, try again");
                break;
        }
        Main();

    }
    public static string AskView_Add()
    {
        Console.WriteLine("Would you like to add an item or view your list? (Add/View)");
        string response = Console.ReadLine();
        return response;
    }
    // -1 = nothing, 1 = add, 2 = view
    public static int ReadResponse(string str)
    {
        if (str == "Add" || str == "add")
        {
            return 1;
        }
        if (str == "View" || str == "view")
        {
            return 2;
        }
        else
        {
            return 0;
        }

    }
}