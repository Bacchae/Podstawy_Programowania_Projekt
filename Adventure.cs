using System;
using System.Collections.Generic;
using System.Linq;

class Adventure {
  Player playerOne;
 // GamesRecord gamesRecord;
  Fight fight;
  GameMenu GameMenu;

  public void NewAdventure () {

    System.Console.WriteLine ("\n\nWchodzisz z karczmy i wyruszasz na szlak. '\n");
      int segment = new Random().Next(1,3);
    GetSegment(segment);
  }



  public void GetSegment (int segment){
    if(segment == 1){    
      System.Console.WriteLine ("\n\n'1, huh? Nigdy nie słyszałem takiego imienia, musisz być tutaj nowy. Tak więc powiedz mi {0}, co cię tutaj sprowadza?'\n\nOdpowiadasz:\n[1] Jestem przejazdem, chcę zwiedzić okolicę\n[2] Przybyłem w poszukiwaniu bogactwa\n[3] Szukam przygody");
     //GameMenu.GameMenu();
    }
    else if(segment == 2){    
      System.Console.WriteLine ("\n\n'2, huh? Nigdy nie słyszałem takiego imienia, musisz być tutaj nowy. Tak więc powiedz mi {0}, co cię tutaj sprowadza?'\n\nOdpowiadasz:\n[1] Jestem przejazdem, chcę zwiedzić okolicę\n[2] Przybyłem w poszukiwaniu bogactwa\n[3] Szukam przygody");
    // GameMenu.GameMenu();
    }
    else{    
     System.Console.WriteLine ("\n\n'3, huh? Nigdy nie słyszałem takiego imienia, musisz być tutaj nowy. Tak więc powiedz mi {0}, co cię tutaj sprowadza?'\n\nOdpowiadasz:\n[1] Jestem przejazdem, chcę zwiedzić okolicę\n[2] Przybyłem w poszukiwaniu bogactwa\n[3] Szukam przygody");
    // GameMenu.GameMenu();
    }
  }

/*
    var input = Console.ReadKey(true).Key; 

    if(input == ConsoleKey.D1){
      System.Console.WriteLine ("\n'To wspaniałe ziemie, ale musisz być ostrożny' odpowiada karczmarz. 'W okolicy czai się wiele potworów, lepiej mieć broń w pogotowiu.'\n");
         AdventureMenu ();
    }else if (input == ConsoleKey.D2){
      System.Console.WriteLine ("\n'Ambitnie!' odpowiada karczmarz. 'Mamy w okolicy trochę ruin, pewnie są w nich jakieś skarby. Możesz też zapolować na potwory, ich skóry są bardzo cenne.'\n\n");
         AdventureMenu ();
    }else if (input == ConsoleKey.D3){
      System.Console.WriteLine ("\n'Przygody na pewno ci w tych okoliach nie braknie' odpowiada karczmarz. 'Wystarczy wyjść na dwór, a jakaś sama z pewnością cię znajdzie.'\n");
    }else{
      System.Console.WriteLine ("\n'Nie do końca rozumiem o czym mówisz' odpowiada karczmarz, po czym macha zbywająco ręką. 'To pewnie przez to, że jesteś obcokrajowcem. '\n");
         AdventureMenu ();
    };

  }
*/

}

