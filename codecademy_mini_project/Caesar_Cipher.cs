using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.Write("Write a secret message: ");
      string var1 = Console.ReadLine();
      string var_lower = var1.ToLower();
      char[] secretMessage = var_lower.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];
      for(int i=0; i<secretMessage.Length; i++){
        char var2 =secretMessage[i];
        int var3 = Array.IndexOf(alphabet, var2);
        int var4 = (var3+3)% alphabet.Length;
        char var5 =alphabet[var4];
        encryptedMessage[i] = var5;
      };
      String.Join("", encryptedMessage);
      Console.WriteLine(encryptedMessage);
    }
  }
}