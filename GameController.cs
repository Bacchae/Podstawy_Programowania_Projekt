using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GameController {
  Game game;
  GamesRecord gamesRecord;

  public GameController () {
      gamesRecord = new GamesRecord();
  }

 public void MainMenuLoop (){
      //System.Console.Clear();
     // ConsoleKeyInfo input = Console.ReadKey(true);

      System.Console.WriteLine ("Witaj w grze, podróżniku. Wybierz, co chcesz zrobić:  \n\n\t[1] Rozpocznij\n\t[2] O grze\n\t[3] (WIP)\n\t[ESC] Exit");

      var input = Console.ReadKey(true).Key; 

      if (input == ConsoleKey.D1){
        game = new Game();
        game.NewGame();
      }
      else if(input == ConsoleKey.D2){
        DisplayRules();
      }
      else if(input == ConsoleKey.D3){
        gamesRecord.DisplayGamesHistory();
      }
      else{
        System.Console.WriteLine ("\n\nNiepoprawny input. Proszę, spróbuj ponownie.");
        MainMenuLoop ();       
      }
  }

  public void DisplayRules () {
    System.Console.WriteLine ("\n\nW grze wcielasz się w poszukiwacza przygód, który dociera do nowej, nieznanej krainy. Walcz z potworami, podróżuj, ulepszaj swoją broń i przede wszystkim – baw się dobrze!\n\n");
    MainMenuLoop ();
  }


}
