using System;

public class PPP
{
    public static void Main()
    {

      string replay = null;

      do{
        int P1 = Choice1();
        int P2 = Choice2();

        string name1 = GetName(P1);
       // name2 = GetName(P2);
       System.Console.WriteLine("alalala, {0}", name1);
        bool correct = Check(P1, P2);
       // bool correct = Check(P2);
         //           System.Console.WriteLine("{0}", correct);
         //  System.Console.WriteLine("alalala, {0}", P1);
        if(correct == false){  
          System.Console.WriteLine("Wrong value. Try again:");
          Main();
        }else{
          System.Console.WriteLine("Player 1 chose {0}", P1);
          System.Console.WriteLine("Do you want to play again? y/n");
          replay = System.Console.ReadLine();
        }
      }while(replay == "y");
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
    

    public static int Choice1()  
    {
        System.Console.WriteLine("Player 1, choose from Sword [1], Bow [2], Axe [3]");
        int weapon1 = int.Parse(Console.ReadLine());
        return weapon1;
    }

    public static int Choice2()  
    {
      Random random = new Random();
      int weapon2 = random.Next(1, 3);  
        return weapon2;
    }

    public static bool Check(int P1, int P2)  
    {
      if ((P1 == 1 || P1 == 2 || P1 == 3) 
         && (P2 == 1 || P2 == 2 || P2 == 3)) {
          return true;
      } else {
          return false;               
      }
    }

  public static string GetName(int P1) 
    {
      string name = null;

      if (P1 == 1 ){
        name = "Sword";
      } else if(P1 == 2 ) {
        name = "Bow";              
      } else if(P1 == 3 ) {
        name = "Axe";              
      }

      return name; 
    }



}


