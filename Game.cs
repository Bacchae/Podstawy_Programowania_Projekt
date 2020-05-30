class Game {
  Player playerOne, playerTwo;
  GamesRecord gamesRecord;

  public Game () {
    playerOne = new Player ();
    playerTwo = new Player ();
    gamesRecord = new GamesRecord ();
  }

  public static void MainLoop (string[] args) 
  {
    string replay = null;

    do{
      int P1 = Choice1();
      int P2 = Choice2();

        bool correct = Check(P1, P2);

        if(correct == false){  
          System.Console.WriteLine("Wrong value. Try again:");
          Main();
        }else{
          System.Console.WriteLine("Player 1 chose {0}", P1);
          System.Console.WriteLine("Player 2 chose {0}", P2);
          Fight(P1, P2);
          System.Console.WriteLine("Do you want to play again? y/n");
          replay = System.Console.ReadLine();
        }
      }while(replay == "y");
    }
    

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


    
    public static int Fight(int P1, int P2)  
    {
      int winner = 1;
      if (P1 == P2)  {
          Console.WriteLine("It's a draft!");
          winner = 0;
        } else if (P1 == 1 && P2 == 2
                   || P1 == 3 && P2 == 1
                   || P1 == 2 && P2 == 3) {
            Console.WriteLine("{0} beats {1}! Player 1 wins!", P1, P2);
            winner = 1;
        } else if (P1 == 2 && P2 == 1
                   || P1 == 1 && P2 == 3
                   || P1 == 3 && P2 == 2) {
            Console.WriteLine("{0} beats {1}! Player 2 wins!", P2, P1);
          winner = 2;
        }
      return winner;
    }
}

