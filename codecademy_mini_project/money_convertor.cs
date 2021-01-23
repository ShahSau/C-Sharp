using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("How much money you want to convert: ");
      string amount = Console.ReadLine();
      double  double_amount = Convert.ToDouble(amount);
      Console.WriteLine($"{double_amount} cents is equal to...");
      int goldValue = 10;
      int silverValue = 5;
      double goldCoins = Math.Floor(double_amount / goldValue);
      double remain = double_amount % goldValue;
      double silverCoins = Math.Floor(remain  / silverValue);
      double remainder = remain % silverValue;
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");
    }
  }
}
