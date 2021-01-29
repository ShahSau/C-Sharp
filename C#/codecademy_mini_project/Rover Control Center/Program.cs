using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 
  		
      Rover[] arr1 = {lunokhod, apollo,sojourner};
      DirectAll(arr1);
      Object[] arr2 = {lunokhod, apollo,sojourner,sputnik};
      foreach(Object j in arr2){
        Console.WriteLine($"Tracking a {j}");
      }
      
      IDirectable[] arr3 = {lunokhod, apollo,sojourner,sputnik};
    }
    public static void DirectAll(IDirectable[] probes)
    {
      foreach(Rover i in probes){
        Console.WriteLine(i.GetInfo());
        Console.WriteLine(i.Explore());
        Console.WriteLine(i.Collect());
      }
    }
  }
}
