using System;

namespace SavingInterface
{
  class TodoList : IDisplayable,IResetable
  {
    
    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
    }
    public void Reset(){
      string[] Todos;
      Todos= new string[5];
      nextOpenIndex=0;
    }
    
    public void Display(){
      foreach(string i in Todos){
        Console.WriteLine(i);
      }
    }
  }
}