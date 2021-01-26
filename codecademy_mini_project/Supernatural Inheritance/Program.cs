using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
   
      Storm[] storms = new Storm[10];
      int stormsIndex = 0;

      Pupil p1 = new Pupil("Mezil-kree", "Icecrown");
      storms[stormsIndex]= p1.CastWindStorm();
      stormsIndex++;
      

      Mage m1 = new Mage("Gul'dan", "Draenor");
      storms[stormsIndex]= m1.CastRainStorm();
      stormsIndex++;
      
      Archmage a1 = new Archmage("Nielas Aran", "Stormwind");
      storms[stormsIndex]= a1.CastWindStorm();
      stormsIndex++;  
      storms[stormsIndex]= a1.CastRainStorm();
      stormsIndex++;
      storms[stormsIndex]= a1.CastLightningStorm();
      stormsIndex++;
      
      for(int i = 0 ; i < stormsIndex; i++)
      {
        Console.WriteLine(storms[i].Announce());
      }


    }
  }
}