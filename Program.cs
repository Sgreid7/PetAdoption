using System;
using System.Collections.Generic;

namespace PetAdoption
{
  class Program
  {
    static void Main(string[] args)
    {
      var shelter = new List<string>();
      var isRunning = true;

      while (isRunning)
      {
        Console.WriteLine("Current Pets");
        Console.WriteLine($"There are {shelter.Count} pets.");
        for (var i = 0; i < shelter.Count; i++)
        {
          var currentPet = shelter[i];
          Console.WriteLine($"{i}:{currentPet}");
        }

        // small menu system
        Console.WriteLine("what would you like to do?");
        Console.WriteLine("(ADD) a pet?");
        Console.WriteLine("(ADOPT) a pet?");
        Console.WriteLine("(QUIT)");
        var input = Console.ReadLine();

        if (input.ToLower() == "add")
        {
          Console.WriteLine("What pet do you want to add?");
          var pet = Console.ReadLine();
          shelter.Add(pet);
        }
        else if (input.ToLower() == "adopt")
        {
          // Delete...remove
          Console.WriteLine("Who is getting adopted today?");
          var pet = Console.ReadLine();
          shelter.Remove(pet);
        }
        else if (input.ToLower() == "quit")
        {
          isRunning = false;
        }

      }
      Console.WriteLine("Goodbye");
    }
  }
}
