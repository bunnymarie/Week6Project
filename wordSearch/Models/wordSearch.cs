namespace wordSearch
{
  public class RepeatCounter
  {
    public static bool returnTest(string userInput)
      {
          string[] userSplit = userInput.Split();
          int foundNumbers = 0;

          for(int i = 0; i < userSplit.Length; i++)
            {
              if (userSplit[i].Contains("you"))
              {
                foundNumbers += 1;
              }
            }

            if(foundNumbers == 4){
              return true;
            }
            else{
              return false;
            }
      }
  }
}
