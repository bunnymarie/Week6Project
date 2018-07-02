namespace wordSearch
{
  public class RepeatCounter
  {
    public static bool returnTest1(string userInput)
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
      public static bool returnTest2(string userInput)
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
        public static bool returnTest3(string userInput)
          {
              string[] userSplit = userInput.Split();
              int foundNumbers = 0;

              for(int i = 0; i < userSplit.Length; i++)
                {
                  if (userSplit[i].Contains("aenean"))
                  {
                    foundNumbers += 1;
                  }
                }

                if(foundNumbers == 3){
                  return true;
                }
                else{
                  return false;
                }
          }
          public static bool returnTest4(string userInput)
            {
                string userLower = userInput.ToLower();
                string[] userSplit = userLower.Split();
                int foundNumbers = 0;

                for(int i = 0; i < userSplit.Length; i++)
                  {
                    if (userSplit[i].Contains("lorem"))
                    {
                      foundNumbers += 1;
                    }
                  }

                  if(foundNumbers == 1){
                    return true;
                  }
                  else{
                    return false;
                  }
            }
            public static bool returnTest5(string userInput)
              {
                  string[] userSplit = userInput.Split();
                  int foundNumbers = 0;

                  for(int i = 0; i < userSplit.Length; i++)
                    {
                      if (userSplit[i].Contains("you"+".") || userSplit[i].Contains("you"+"?") || userSplit[i].Contains("you"+",") || userSplit[i].Contains("you"+"!"))
                      {
                        foundNumbers += 1;
                      }
                      else if (userSplit[i] == "you"){
                        foundNumbers += 1;
                      }
                    }

                    if(foundNumbers == 3){
                      return true;
                    }
                    else{
                      return false;
                    }
              }
  }
}
