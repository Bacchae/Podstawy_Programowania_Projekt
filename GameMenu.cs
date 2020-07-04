using System;
using System.Collections.Generic;
using System.Linq;

class GameMenu {
  Fight fight;

  public GameMenu () {
    
      //System.Console.Clear();
      System.Console.WriteLine ("\n\nZakończywszy przygodę wracasz do karczmy.\n Co zamierzasz teraz zrobić?\t\n[1] Walcz z potworem\n\t[2] Wyrusz na przygodę (WIP)\n\t[3] Odwiedź kowala(WIP)\n\t[ESC] Exit");
  
      var input = Console.ReadKey(true).Key; 
      
      if (input == ConsoleKey.D1){
        fight = new Fight();
        fight.InitializeFight();

      }
      else if (input == ConsoleKey.D2){
        fight.InitializeFight();
      }
      else if (input == ConsoleKey.D3){
        fight.InitializeFight();
      }

  }

}

