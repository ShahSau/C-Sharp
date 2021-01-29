// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm : Spell
  {
 
//constructor
    public Storm(string essence, bool isStrong, string caster){
      Essence = essence;
      IsStrong = isStrong;
      Caster = caster;
    }

//methods
    public override string Announce(){
      // setting strength field using ternary conditional operator
      string strength = IsStrong == true ? "strong" : "weak";
      return $"{Caster} cast a {strength} {Essence} storm!";
    }
    
  }
}