/*Architects have big ideas – but big ideas can be expensive. How expensive? Depends on the size.

In this project, you’ll use methods to build a program that calculates the material cost for any architect’s floor plan. F
or example, the floor plan of the Pantheon in Rome, Italy:*/

using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      calculation();
      
    }
    static double Rect(double length, double width)
    {
      return length * width;
    }
    static double Circle(double radius)
    {
      return Math.PI * Math.Pow(radius,2);
    }
    static double Triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
    static double calculation()
    {
      double total_area= Rect(2500,1500)+Triangle(750,500)+(Circle(375)/2);
      double total_cost = total_area*180;
      
      double total_cost_decimal=Math.Round(total_cost, 2);
      Console.WriteLine($"My plan cost is :{total_cost_decimal} pesos");
      return total_cost_decimal;
      
    }
  }
}
