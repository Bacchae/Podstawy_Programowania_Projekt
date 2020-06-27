using System;
using System.Collections.Generic;
using System.Linq;

class Game {
  Player playerOne;
  GamesRecord gamesRecord;

  public Game () {
    System.Console.WriteLine ("\n\nWchodzisz do karczmy. Zza lady spogląda na ciebie karczmarz i mówi: 'Jak masz na imię, podróżniku?'\n");
    playerOne = new Player ();
    string playerName = playerOne.playerName;

    gamesRecord = new GamesRecord ();
    GameStartChat(playerName);
  //  MainMenuLoop ();
  }


  public string GetPlayerInput (Player player){
    string rawInput;
    string properInput;
    System.Console.WriteLine ("\n\nWybierz swoją broń:\n[1] Miecz\n[2] Topór\n[3] Włócznia");
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


  public string DetermineWinner (string playerOneChoice, string playerTwoChoice){
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
      System.Console.WriteLine ("Przegrałeś!");
      return "Player Two won";
    }
  }

  public void Play () {

    do{

      System.Console.Clear ();
      string firstPlayerChoiceString = GetPlayerInput(playerOne);

     //System.Console.Clear ();
     // string secondPlayerChoiceString = GetPlayerInput(playerTwo);

      string secondPlayerChoiceString = GetRandomWeapon ();


      System.Console.Clear ();

      string gameResult = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString);

      gamesRecord.AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult); 

      System.Console.WriteLine("Do you want to play again? y/n");

    }while(System.Console.ReadLine() == "y");
    AdventureMenu ();
  }


  public void GameStartChat (string playerName){


    System.Console.WriteLine ("\n\n'{0}, huh? Nigdy nie słyszałem takiego imienia, musisz być tutaj nowy. Tak więc powiedz mi {0}, co cię tutaj sprowadza?'\n\nOdpowiadasz:\n[1] Jestem przejazdem, chcę zwiedzić okolicę\n[2] Przybyłem w poszukiwaniu bogactwa\n[3] Szukam przygody", playerName);

    string response;
    response = System.Console.ReadLine();

    if(response == "1"){
      System.Console.WriteLine ("\n'To wspaniałe ziemie, ale musisz być ostrożny' odpowiada karczmarz. 'W okolicy czai się wiele potworów, lepiej mieć broń w pogotowiu.'\n");
         AdventureMenu ();
    }else if (response == "2"){
      System.Console.WriteLine ("\n'Ambitnie!' odpowiada karczmarz. 'Mamy w okolicy trochę ruin, pewnie są w nich jakieś skarby. Możesz też zapolować na potwory, ich skóry są bardzo cenne.'\n\n");
         AdventureMenu ();
    }else if (response == "3"){
      System.Console.WriteLine ("\n'Przygody na pewno ci w tych okoliach nie braknie' odpowiada karczmarz. 'Wystarczy wyjść na dwór, a jakaś sama z pewnością cię znajdzie.'\n");
    }else{
      System.Console.WriteLine ("\n'Nie do końca rozumiem o czym mówisz' odpowiada karczmarz, po czym macha zbywająco ręką. 'To pewnie przez to, że jesteś obcokrajowcem. '\n");
         AdventureMenu ();
    };


  }

 public void AdventureMenu (){
      //System.Console.Clear();
      System.Console.WriteLine ("Co zamierzasz teraz zrobić?\n\t[1] Walcz z potworem\n\t[2] Wyrusz na przygodę (WIP)\n\t[3] Odwiedź sklep(WIP)\n\t[ESC] Exit");
 

      if (System.Console.ReadLine() == "1"){
        Play ();
      }
      else if (System.Console.ReadLine() == "2"){
        Play ();
      }
      else if (System.Console.ReadLine() == "3"){
        Play ();
      }

  }

}

