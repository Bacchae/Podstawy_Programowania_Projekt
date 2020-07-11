using System;
using System.Collections.Generic;
using System.Linq;

class GameMenu {
  Fight fight;
  Adventure adventure;

  public GameMenu () {
    
      //System.Console.Clear();
      System.Console.WriteLine ("\n\nZakończywszy przygodę wracasz do karczmy.\n Co zamierzasz teraz zrobić?\n\t[1] Walcz z potworem\n\t[2] Wyrusz na przygodę\n\t[3] Odwiedź kowala(WIP)\n");
  
      var input = Console.ReadKey(true).Key; 
      
      if (input == ConsoleKey.D1){
        fight = new Fight();
        fight.InitializeFight();

      }
      else if (input == ConsoleKey.D2){
        adventure = new Adventure ();
        adventure.NewAdventure ();
      }
      else if (input == ConsoleKey.D3){
        GameMenu ();
      }
      else {
        GameMenu ();
      }

  }

}

