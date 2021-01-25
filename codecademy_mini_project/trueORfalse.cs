/*
True or False?
*/

using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions ={"Eating cabbage can help reduce your risk for some cancers", "Vegetables don't have calcium.", "vegetables won’t affect their nutritional content.", "The deeper the color of a vegetable, the more beta-carotene it has.", "Dietary fiber, found in most fresh fruits and vegetables, is also found in animal products"};
      bool[] answers = {true, false, false, true,false};
      bool [] responses = new bool [questions.Length];
      if(questions.Length != answers.Length){
        Console.WriteLine("Warning, There is not enough answers!!");
      }
      int askingIndex = 0;
      foreach(string i in questions){
        string input;
        string input_caps;
        bool isBool;
        bool inputBool;
        Console.WriteLine(i);
        Console.WriteLine("true or false?");
        input_caps= Console.ReadLine();
        input = input_caps.ToLower();
        isBool = Boolean.TryParse(input, out inputBool);
        while (!isBool){
          Console.WriteLine("Please respond with 'true' or 'false'");
          input_caps = Console.ReadLine();
          input = input_caps.ToLower();
        isBool = Boolean.TryParse(input, out inputBool);
        };
        responses[askingIndex]=inputBool;
        askingIndex++;

      };
      Console.WriteLine(responses);
      int scoringIndex =0;
      int score =0;
      foreach(bool j in answers){
        bool user_response =responses[scoringIndex];
        Console.WriteLine($"Input: {user_response} | Answer: {j}");
        if(user_response == j){
          score++;
        };
        scoringIndex++;
      };
      Console.WriteLine($"You got {score} out of {questions.Length} correct!");
    }
  }
}
