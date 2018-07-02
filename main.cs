using System;
class wordSearch
{
  public string userWriting { get; set;}

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("This is a program to help you find how many times you've used a word in a piece of writing. Please enter a writing sample we'll be searching from.")
      string userWriting = Console.ReadLine();
      Console.WriteLine("Please enter the word we're searching for.")
      string userWord = Console.ReadLine();

      string[] userSplit = userWriting.Split();
      int foundNumbers = 0;

      for(int i = 0; i < userSplit.Length; i++)
        {
          if (userSplit[i].Contains(userWord))
          {
            foundNumbers += 1;
          }
        }
      Console.WriteLine("You used the word" + userWord + foundNumbers + "times.")
    }
  }
}
