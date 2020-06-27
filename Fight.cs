using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Fight {
  Player playerOne;
  Game game;
  GamesRecord gamesRecord;


  public Fight () {
      gamesRecord = new GamesRecord();
  }
  
  
  public void InitializeFight () {

    do{

      System.Console.Clear ();
      string firstPlayerChoiceString = GetPlayerInput();
      string secondPlayerChoiceString = GetRandomWeapon ();


      System.Console.Clear ();

     // string gameResult = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);

    //  gamesRecord.AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult); 

      FightLoop();

      System.Console.WriteLine("Do you want to play again? y/n");
    }while(System.Console.ReadLine() == "y");
    game.AdventureMenu();
  }

public void FightLoop() {

     //   int currentHealth = playerOne.health;

    /*  string firstPlayerChoiceString, string secondPlayerChoiceString 
    
    do{  

        string gameResult = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);

        gamesRecord.AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult); 
        currentHealth = currentHealth - 1;
      }while(currentHealth != 0);
    return game.AdventureMenu(); */

      System.Console.WriteLine ("Przegrałeś!");
      game.AdventureMenu();

  }



  public string GetPlayerInput (){
      string rawInput;
      string properInput;
      System.Console.WriteLine ("Wybierz swoją broń:\n[1] Miecz\n[2] Topór\n[3] Włócznia");
      rawInput = System.Console.ReadLine();
      while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
          System.Console.WriteLine ("Wrong input. Please enter correct one.\nPlayer One, choose:\n[1] Miecz\n[2] Topór\n[3] Włócznia");
          rawInput = System.Console.ReadLine();
      }
      if (rawInput == "1") { properInput = "Miecz"; }
      else if (rawInput == "2") { properInput = "Topór"; }
      else { properInput = "Włócznia"; }
      return properInput;
    }

    public string GetRandomWeapon ()
    {
      int weapon = new Random().Next(1,3);
      if(weapon == 1){
        string playerTwoChoice = "Miecz";
        return playerTwoChoice;
      }else if(weapon == 2){
        string playerTwoChoice = "Topór";
        return playerTwoChoice;
      }else if(weapon == 3){
        string playerTwoChoice = "Włócznia";
        return playerTwoChoice;
      } else{
        return GetRandomWeapon ();
      }
    }


  public string DetermineWinner (string playerOneChoice, string playerTwoChoice){
       System.Console.WriteLine ("Wybrałeś broń {0}. Potwór wybrał broń {1}", playerOneChoice, playerTwoChoice);

    if (playerOneChoice == playerTwoChoice){
        System.Console.WriteLine ("Remis!");
        return "draw";
    }
    else if ((playerOneChoice == "Miecz" && playerTwoChoice == "Włócznia") ||
            (playerOneChoice == "Topór" && playerTwoChoice == "Miecz") ||
            (playerOneChoice == "Włócznia" && playerTwoChoice == "Topór")){
      System.Console.WriteLine ("Zwycięstwo!");
      return "Player One won";
    }
    else{
      System.Console.WriteLine ("Przegrałeś!");
      return "Player Two won";
    }
  }


}