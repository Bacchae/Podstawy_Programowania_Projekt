using System;

public class PPP
{
    public static void Main()
    {
      int P1 = Choice();
      bool correct = Check(P1);
                  System.Console.WriteLine("{0}", correct);
        System.Console.WriteLine("alalala, {0}", P1);
      do{
        System.Console.WriteLine("Wybrano wartość spoza zakresu. Spróbuj ponownie:");
        Main();
      }while(correct == false);
      System.Console.WriteLine("Player 1 chose {0}", P1);
    }

/*

      if (P1 == P2)  {
          Console.WriteLine("It's a draft!");
        } else if (P1 == "Rock" && P2 == "Scissors"
                   || P1 == "Paper" && P2 == "Rock"
                   || P1 == "Scissors" && P2 == "Paper") {
            Console.WriteLine("{0} beats {1}! Player 1 wins!", P1, P2);
        } else if (P1 == "Scissors" && P2 == "Rock"
                   || P1 == "Rock" && P2 == "Paper"
                   || P1 == "Paper" && P2 == "Scissors") {
            Console.WriteLine("{0} beats {1}! Player 2 wins!", P2, P1);
        }else{
         Console.WriteLine("Oops! Something went wrong!");
        }
*/
    

    public static int Choice()  
    {
        System.Console.WriteLine("Player 1, choose from Sword [1], Bow [2], Axe [3]");
        int weapon = int.Parse(Console.ReadLine());
      //  Console.Clear();
       // System.Console.WriteLine("Player 2, choose from Rock, Scissors, Paper");
      //  string P2 = System.Console.ReadLine();
        //Console.Clear();
        //System.Console.WriteLine("Player 1 chose {0}", P1);
        //System.Console.WriteLine("Player 2 chose {0}", P2);
        

        return weapon;
    }


    public static bool Check(int P1)  
    {
      if (P1 == 1 || P1 == 2 || P1 == 3) {
          return true;
      } else {
      return false;               
      }
    }

}


