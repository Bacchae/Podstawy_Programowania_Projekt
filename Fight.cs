using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Fight {
 // Player playerOne;
  Game game;
  GamesRecord gamesRecord;
  GameMenu gameMenu;


  public Fight () {
      gamesRecord = new GamesRecord();
  }
  
  
  public void InitializeFight () {

      System.Console.Clear ();
      int currentHealth = 3;
      FightLoop(currentHealth);

  }

public void FightLoop(int currentHealth) {


    while (currentHealth != 0)
    {

      string firstPlayerChoiceString = GetPlayerInput();
      string secondPlayerChoiceString = GetRandomWeapon ();

      string gameResult = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString, currentHealth);

      gamesRecord.AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult); 

      System.Console.WriteLine ("Twoje HP: {0}", currentHealth);

    if (currentHealth == 0)
        break;     
    }  
        gameMenu = new GameMenu();
     //   fight.InitializeFight();


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


  public dynamic DetermineWinner (string playerOneChoice, string playerTwoChoice, int currentHealth){
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
      System.Console.WriteLine ("Otrzymujesz obrażenia!");
      currentHealth = currentHealth - 1;
      FightLoop( currentHealth);
      return currentHealth;
    }
  }

}