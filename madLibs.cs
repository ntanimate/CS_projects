using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Madlib program 
      Author: Ninette T
      */


      // Let the user know that the program is starting:


      // Give the Mad Lib a title:
      string title = "Let's play MadLibs!";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Type in a name.");
      string name = Console.ReadLine();
      Console.WriteLine("Type in an adjective.");
      string adjective1 = Console.ReadLine();
      Console.WriteLine("Type in another adjective.");
      string adjective2 = Console.ReadLine();
      Console.WriteLine("Type in a noun.");
      string noun = Console.ReadLine();
      Console.WriteLine("Type in another noun.");
      string noun2 = Console.ReadLine();
      Console.WriteLine("Type in another noun.");
      string noun3 = Console.ReadLine();
      Console.WriteLine("Type in a present tense verb.");
      string verb = Console.ReadLine();
      Console.WriteLine("Type in a type of music.");
      string musicType = Console.ReadLine();
      Console.WriteLine("Type in an emotion.");
      string emotion = Console.ReadLine();
      Console.WriteLine("Type in an adverb.");
      string adverb = Console.ReadLine();
      Console.WriteLine("Type in a name of a place.");
      string place = Console.ReadLine();
      Console.WriteLine("Type in a different name of a person.");
      string name2 = Console.ReadLine();
      Console.WriteLine("Type in a year.");
      string year = Console.ReadLine();
      
      // The template for the story, print out:

      Console.WriteLine($"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {noun}s were protesting to keep {noun2} in stores. They began to {verb} to the rhythm of the {musicType}, which made all the {noun2}s very {emotion}. Concerned, {name} texted {name2}, who flew {adverb} to {place} and dropped {noun} in a puddle of frozen {noun3}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.");


     
      
    }
  }
}
