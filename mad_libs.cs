using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program does the following...
      Author: Shahriar...
      */


      // Let the user know that the program is starting:
      Console.WriteLine("The mad lab has started");

      // Give the Mad Lib a title:
      string title = "nothing";

      Console.WriteLine(title);
      // Define user input and variables:
Console.Write("Enter a name: ");
string name = Console.ReadLine();

Console.Write("Enter first adjective: ");
string adj1 = Console.ReadLine();

Console.Write("Enter second adjective: ");
string adj2 = Console.ReadLine();

Console.Write("Enter third adjective: ");
string adj3 = Console.ReadLine();

Console.Write("Enter a verb: ");
string verb1 = Console.ReadLine();

Console.Write("Enter a noun: ");
string noun1 = Console.ReadLine();

Console.Write("Enter another noun: ");
string noun2 = Console.ReadLine();

Console.Write("Enter a animal name: ");
string animal = Console.ReadLine();

Console.Write("Enter a food name: ");
string food = Console.ReadLine();

Console.Write("Enter a fruit name: ");
string fruit = Console.ReadLine();

Console.Write("Enter a superhero name: ");
string superhero = Console.ReadLine();

Console.Write("Enter a country name: ");
string country = Console.ReadLine();

Console.Write("Enter a dessert name: ");
string dessert = Console.ReadLine();

Console.Write("Enter an year: ");
string year = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:


Console.WriteLine(story);

    }
  }
}
