using System;

class GameController {
  Game game;
  GamesRecord gamesRecord;

  public GameController () {
      gamesRecord = new GamesRecord();
  }

  public void DisplayRules () {
    System.Console.WriteLine ("The rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!");
  }

 public void MainMenuLoop (){
      //System.Console.Clear();
      System.Console.WriteLine ("No to co teraz? \n\t[1] Walcz z potworem\n\t[2] Wyrusz na przygodę (WIP)\n\t[3] Odwiedź sklep(WIP)\n\t[ESC] Exit");
 

      if (System.Console.ReadLine() == "1"){
        game = new Game();
        game.Play();
      }
      else if (System.Console.ReadLine() == "2"){
        DisplayRules();
      }
      else if (System.Console.ReadLine() == "3"){
        gamesRecord.DisplayGamesHistory();
      }

  }



}
