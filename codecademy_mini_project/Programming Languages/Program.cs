using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();
        foreach(var i in languages){
          //Console.WriteLine(i.Prettify());
        }
        var Query2 = languages
          .Select(l => $"{l.Year}, {l.Name}, {l.ChiefDeveloper}");
      foreach(var j in Query2){
       // Console.WriteLine(j.Prettify());
    }
    var Query3 = languages.Where(l=>l.Name.Contains("C#"));
    foreach(var j in Query3){
        //Console.WriteLine(j.Prettify());
    }
       var Query4 = languages.Where(l=>l.ChiefDeveloper.Contains("Microsoft"));
    foreach(var j in Query4){
       // Console.WriteLine(j.Prettify());
    }
     var Query5 = languages.Where(l=>l.Predecessors.Contains("Lisp"));
    foreach(var j in Query5){
        //Console.WriteLine(j.Prettify());
    }
    var Query6 = languages
    .Where(l=>l.Name.Contains("Script"))
    .Select(l=>l.Name);
    foreach(var j in Query6){
        //Console.WriteLine(j);
    }
    var Query7 = languages.Select(l=>l.Name);
    //Console.WriteLine(Query7.Count());

  var Query8 = languages
  .Where(l => l.Year >= 1995 && l.Year <= 2005)
  .Select(l => $"{l.Name} was invented in {l.Year}");

    //Console.WriteLine(Query8.Count());
   
}
public static void PrettyPrintAll(IEnumerable<Language> langs)
{
  foreach(Language i in langs){
    Console.WriteLine(i.Prettify());
  }
}
public static void PrintAll(IEnumerable<Object> sequence){
  foreach(Object j in sequence)
  {
    Console.WriteLine(j);
  }
}
}
  }

