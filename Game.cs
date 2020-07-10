using System;
using System.Collections.Generic;
using System.Linq;

class Game {
  Player playerOne;
 // GamesRecord gamesRecord;
  Fight fight;
  Adventure adventure;

  public Game () {
    System.Console.Clear ();
    System.Console.WriteLine ("Wchodzisz do karczmy. Zza lady spogląda na ciebie karczmarz i mówi: 'Jak masz na imię, podróżniku?'\n");
  //  gamesRecord = new GamesRecord ();
    playerOne = new Player ();

  //  MainMenuLoop ();
  }


  public void NewGame (){

    string playerName = playerOne.playerName;
    GameStartChat(playerName);

  }

  public void GameStartChat (string playerName){
    System.Console.Clear ();
    System.Console.WriteLine ("'{0}, huh? Nigdy nie słyszałem takiego imienia, musisz być tutaj nowy. Tak więc powiedz mi {0}, co cię tutaj sprowadza?'\n\nOdpowiadasz:\n[1] Jestem przejazdem, chcę zwiedzić okolicę\n[2] Przybyłem w poszukiwaniu bogactwa\n[3] Szukam przygody", playerName);

    var input = Console.ReadKey(true).Key; 
System.Console.Clear ();
    if(input == ConsoleKey.D1){
      System.Console.WriteLine ("'To wspaniałe ziemie, ale musisz być ostrożny' odpowiada karczmarz. 'W okolicy czai się wiele potworów, lepiej mieć broń w pogotowiu.'\n");
         AdventureMenu ();
    }else if (input == ConsoleKey.D2){
      System.Console.WriteLine ("'Ambitnie!' odpowiada karczmarz. 'Mamy w okolicy trochę ruin, pewnie są w nich jakieś skarby. Możesz też zapolować na potwory, ich skóry są bardzo cenne.'\n");
         AdventureMenu ();
    }else if (input == ConsoleKey.D3){
      System.Console.WriteLine ("'Przygody na pewno ci w tych okoliach nie braknie' odpowiada karczmarz. 'Wystarczy wyjść na dwór, a jakaś sama z pewnością cię znajdzie.'\n");
    }else{
      System.Console.WriteLine ("'Nie do końca rozumiem o czym mówisz' odpowiada karczmarz, po czym macha zbywająco ręką. 'To pewnie przez to, że jesteś obcokrajowcem.'\n");
         AdventureMenu ();
    };

  }

 public void AdventureMenu (){
      System.Console.WriteLine ("\n Co zamierzasz teraz zrobić?\n\t[1] Walcz z potworem\n\t[2] Wyrusz na przygodę \n\t[3] Odwiedź kowala(WIP)\n");
  
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
        fight.InitializeFight();
      }else{
        System.Console.WriteLine ("Niepoprawny wybór, spróbuj ponownie.");
        AdventureMenu (); }

  }

}

