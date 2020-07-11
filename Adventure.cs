using System;
using System.Collections.Generic;
using System.Linq;

class Adventure : Encounter{
 // GameMenu gameMenu;
  Fight fight;
 // Player playerOne;

  public void NewAdventure () {
    int segment = new Random().Next(1,3);
    GetSegment(segment);
  }


  public void GetSegment (int segment){
    System.Console.Clear ();
    if(segment == 1){    
      System.Console.WriteLine ("Kiedy podróżujesz szlakiem, na twojej drodze staje potwór.\n");
        fight = new Fight();
        fight.InitializeFight();
    }
    else if(segment == 2){    
      System.Console.WriteLine ("'Kręciłeś się po okolicy przez kilka godzin, ale nic się nie stało.\n Co zamierzasz teraz zrobić?\n\t[1] Idź dalej\n\t[2] Zawróć");

      var input = Console.ReadKey(true).Key; 
      
      if (input == ConsoleKey.D1){
        NewAdventure ();
      }
      else if (input == ConsoleKey.D2){
        gameMenu = new GameMenu();
      }else{      
        GetSegment(segment);
      }

    }
    else{    
      int newGold = new Random().Next(10,100);
     // int currentGold = playerOne.UpdateGold(newGold);
     // int gold = newGold + playerOne.currentGold;
     // int nowGold = playerOne.currentGold;
      System.Console.WriteLine ("Podróżując po bezdrożach, natrafiaz na zwłoki innego śmiałka, któremu się nie poszczęściło. Potwory rozszarpały jego ciało na strzępy, ale ekwipunek pozostaje nietknięty.\n Znajdujesz {0} złota.\n\n Co zamierzasz teraz zrobić?\n\t[1] Idź dalej\n\t[2] Zawróć", newGold);
      
      var input = Console.ReadKey(true).Key; 
      
      if (input == ConsoleKey.D1){
        NewAdventure ();
      }
      else if (input == ConsoleKey.D2){
        gameMenu = new GameMenu();
      }
      else{      
        GetSegment(segment);
      }
    }
  }


}

