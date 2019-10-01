using System.Collections.Generic;
using System;
using ToDoList.Models;

public class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to the list of stuff to do:");
    ListAdder();
  }

  static void ListAdder()
  {

    Console.WriteLine("Would you like to add a new item or view your list? (add/view)");
    string userInput = Console.ReadLine();

    if (userInput.ToLower() == "add")
    {
      Console.WriteLine("Please enter the description of the new item.");
      string userDescription = Console.ReadLine();
      Item newItem = new Item(userDescription);
      Console.WriteLine(userDescription + " has been added to the list.");
      ListAdder();
    } 
    else if (userInput.ToLower() == "view")
    {
      List<Item> displayList = Item.GetAll();
      Console.WriteLine("This is on your to do list:");
      foreach(Item item in displayList)
      { 
        Console.WriteLine("-" + item.Description);
      }
      Console.WriteLine("\n");
      ListAdder();
    }
    else
    {
      Console.WriteLine("Please enter 'add' or 'view'. If you would like to exit enter 'Ctl + C'\n----------------------------------------------------------------------------");
      ListAdder();
    }
  }
}
