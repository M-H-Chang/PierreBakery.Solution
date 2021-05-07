using System;
using Bakery;

namespace Bakery.CLI
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery, each loaf of bread is $5 and each pastry is $2. Specials: Buy two or more loafs of bread and get one free! Buy 3 or more pastries and get one half off!");
      Console.Write("How many loafs of bread do you want?");
      string breadInput = Console.ReadLine();
      int breadPrice = int.Parse(breadInput);
      Console.WriteLine($"Your total is ${Bread.Loaf(breadPrice)}");

    }
  }
}