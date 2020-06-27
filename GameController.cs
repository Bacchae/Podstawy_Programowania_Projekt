using System;

class GameController {
  Game game;
  GamesRecord gamesRecord;

  public GameController () {
      gamesRecord = new GamesRecord();
  }

 public void MainMenuLoop (){
      //System.Console.Clear();
      System.Console.WriteLine ("Witaj w grze, podróżniku. Wybierz, co chcesz zrobić:  \n\n\t[1] Rozpocznij\n\t[2] O grze\n\t[3] (WIP)\n\t[ESC] Exit");
 

      if (System.input.Key == System.ConsoleKey.D1){
        game = new Game();
        game.Play();
      } 
      else if (System.input.Key == System.ConsoleKey.D2){
        DisplayRules();
      }
      else if (System.input.Key == System.ConsoleKey.D3){
        gamesRecord.DisplayGamesHistory();
      }
      else{
        System.Console.WriteLine ("Niepoprawny input. Proszę, spróbuj ponownie.");
        MainMenuLoop ();       
      }
  }

  public void DisplayRules () {
    System.Console.WriteLine ("W grze wcielasz się w poszukiwacza przygód, który dociera do nowej, nieznanej krainy. Walcz z potworami, podróżuj, ulepszaj swoją broń i przede wszystkim – baw się dobrze!\n\n");
    MainMenuLoop ();
  }


}
