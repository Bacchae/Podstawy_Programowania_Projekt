using System;

public class PRS
{
    public static void Main()
    {
    // int player;

      int P1 = Choice();
      System.Console.WriteLine("Player 1 chose {0}", P1);
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
    }

    static int Choice()  
    {

        System.Console.WriteLine("Player 1, choose from Rock [1], Scissors [2], Paper [3]");
        int weapon = int.Parse(Console.ReadLine());
        Console.Clear();
       // System.Console.WriteLine("Player 2, choose from Rock, Scissors, Paper");
      //  string P2 = System.Console.ReadLine();
        //Console.Clear();
        //System.Console.WriteLine("Player 1 chose {0}", P1);
        //System.Console.WriteLine("Player 2 chose {0}", P2);
        

        return weapon;
    }
   // }
}


