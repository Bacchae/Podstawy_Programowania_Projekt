using System;

class Game {
  Player playerOne;
  GamesRecord gamesRecord;

  public Game () {
    System.Console.WriteLine ("Wchodzisz do karczmy. Zza lady spogląda na ciebie karczmarz i mówi: 'Podaj mi swoje imię, podróżniku.'");
    playerOne = new Player ();
    string playerTwoChoice = null;
    GetRandomWeapon ();
    gamesRecord = new GamesRecord ();
    MainMenuLoop ();
  }

  public void DisplayRules (bool withWelcomeMessage = true) {
    if (withWelcomeMessage) {
      System.Console.WriteLine ("Welcome to a simple Rock-Paper-Scissors game!");
    }
    System.Console.WriteLine ("The rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!");
  }

  public string GetPlayerInput (Player player){
    string rawInput;
    string properInput;
    System.Console.WriteLine ("{0}, Choose:\n[1] Rock\n[2] Paper\n[3] Scissors", player.playerName);
    rawInput = System.Console.ReadLine();
    while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
        System.Console.WriteLine ("Wrong input. Please enter correct one.\nPlayer One, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
        rawInput = System.Console.ReadLine();
    }
    if (rawInput == "1") { properInput = "Rock"; }
    else if (rawInput == "2") { properInput = "Paper"; }
    else { properInput = "Scissors"; }
    return properInput;
  }

  public int GetRandomWeapon ()
  {
    int weapon = new Random().Next(1,3);
    if(weapon == 1){
      playerTwoChoice = "Rock";
      return playerTwoChoice;
    }else if(weapon == 2){
      playerTwoChoice = "Paper";
      return playerTwoChoice;
    }else if(weapon == 3){
      playerTwoChoice = "Scissors";
      return playerTwoChoice;
    }
    return weapon;
  }


  public string DetermineWinner (string playerOneChoice, string playerTwoChoice){
    if (playerOneChoice == playerTwoChoice){
        System.Console.WriteLine ("It's a draw!");
        return "Draw";
    }
    else if ((playerOneChoice == "Rock" && playerTwoChoice == "Scissors") ||
            (playerOneChoice == "Paper" && playerTwoChoice == "Rock") ||
            (playerOneChoice == "Scissors" && playerTwoChoice == "Paper")){
      System.Console.WriteLine ("Player One won!");
      return "Player One won";
    }
    else{
      System.Console.WriteLine ("Player Two won!");
      return "Player Two won";
    }
  }

  public void Play () {

    do{

      System.Console.Clear ();
      string firstPlayerChoiceString = GetPlayerInput(playerOne);

     // System.Console.Clear ();
      //string secondPlayerChoiceString = GetPlayerInput(playerTwo);

      System.Console.Clear ();

      string gameResult = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);

      gamesRecord.AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult); 

      System.Console.WriteLine("Do you want to play again? y/n");

    }while(System.Console.ReadLine() == "y");

  }


  public void MainMenuLoop (){

      System.Console.Clear();
      System.Console.WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");

      if (System.Console.ReadLine() == "1"){
        Play();
      }
      else if (System.Console.ReadLine() == "2"){
        DisplayRules(false);
      }
      else if (System.Console.ReadLine() == "3"){
        gamesRecord.DisplayGamesHistory();
      }

  }



}

