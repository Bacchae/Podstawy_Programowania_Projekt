using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Fight : Encounter {
 // Player playerOne;
 // Game game;
//  GamesRecord gamesRecord;
 // GameMenu gameMenu;


  int fightRecordSize;
  IRecord[] fightRecord;
  int fightRecordCurrentIndex;
  int fightRecordCurrentSize;
  bool fightStart = true;
  int turn = 0;
  string turnRecord = "0";
  string gameResult;
  bool hit;

  public Fight () {
     // gamesRecord = new GamesRecord();
  }
  
  
  public void InitializeFight () {

    //  System.Console.Clear ();
      int currentHealth = 3;
      FightLoop(currentHealth);

  }

public void FightLoop(int currentHealth) {

    bool death = false;
    FightRecord();

    do{
      hit = false;

      if(fightStart == true){
      System.Console.WriteLine ("\nNowa walka!");
      fightStart = false;
      }

      if(currentHealth == 0){
          death = true;
      }


      turn = turn + 1;
      string turnRecord = turn.ToString();

      System.Console.WriteLine ("\nTura #{0}", turn);
      System.Console.WriteLine ("Twoje HP: {0}", currentHealth);

      string firstPlayerChoiceString = GetPlayerInput();
      string secondPlayerChoiceString = GetRandomWeapon ();

      string gameResult = DetermineWinner(firstPlayerChoiceString, secondPlayerChoiceString, currentHealth, turnRecord);

      if(hit == true){
       currentHealth = currentHealth - 1;
      }

    AddRecord(new RecordFight(firstPlayerChoiceString, secondPlayerChoiceString, gameResult, turnRecord));


  //    AddRecord(firstPlayerChoiceString, secondPlayerChoiceString, gameResult, turnRecord, turn); 

  //     DisplayFightHistory ();
    
    }while (death == false);

    DisplayFightHistory ();
    System.Console.WriteLine ("\nPrzegrałeś!\n");
    gameMenu = new GameMenu();
     //   fight.InitializeFight();

  }

/*
  Dictionary<int, string> inputTable = new Dictionary<int, string> () 
    {
      {1, "Miech"},
      {2, "Topór"},
      {3, "Włócznia"}
    };*/


  public string GetPlayerInput (){
    //  var rawInput = 0;
      string properInput;

      System.Console.WriteLine ("Wybierz swoją broń:\n\t[1] Miecz\n\t[2] Topór\n\t[3] Włócznia\n");

      ConsoleKeyInfo UserInput = System.Console.ReadKey();

      int rawInput = int.Parse(UserInput.KeyChar.ToString());

      if (rawInput != 1 && rawInput != 2 && rawInput != 3) {
          System.Console.WriteLine ("\nWrong input. Please enter correct one!\n");
          GetPlayerInput ();
      }

      if (rawInput == 1) { 
        properInput = "Miecz"; 
      }
      else if (rawInput == 2) {
         properInput = "Topór"; 
      }
      else { 
        properInput = "Włócznia"; 
      }
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


  public dynamic DetermineWinner (string playerOneChoice, string playerTwoChoice, int currentHealth, string turnRecord){
       System.Console.WriteLine ("\nWybrałeś broń {0}. Potwór wybrał broń {1}", playerOneChoice, playerTwoChoice);

    if (playerOneChoice == playerTwoChoice){
        System.Console.WriteLine ("Remis!");
        gameResult = "Remis";

        return "Remis";
    }
    else if ((playerOneChoice == "Miecz" && playerTwoChoice == "Włócznia") ||
            (playerOneChoice == "Topór" && playerTwoChoice == "Miecz") ||
            (playerOneChoice == "Włócznia" && playerTwoChoice == "Topór")){
      System.Console.WriteLine ("Zadajesz obrażenia!");

      return "Zadałeś obrażenia";
    }
    else{
      System.Console.WriteLine ("Otrzymujesz obrażenia!");
      hit = true;
      return "Potwór zadał obrażenia";
    }
  }


  public void FightRecord (int recordSize = 100) {
      try {
        fightRecordSize = recordSize;
        fightRecord = new IRecord[fightRecordSize];
      }
      catch (OverflowException e) {
        System.Console.WriteLine("OverflowException during FightRecord initialization: \"{0}\"\nrecordSize given was [{1}]\nSetting recordSize to 10", e.Message, recordSize);
        fightRecordSize = 100;
        fightRecord = new IRecord[fightRecordSize];
      }
      fightRecordCurrentIndex = 0;
      fightRecordCurrentSize = fightRecordCurrentSize++;
    }

  private void AddRecord (IRecord record) {

  /* System.Console.WriteLine ("Tura #{0}:\t{1}\t-\t{2},\t{3}  {4}",
          turnRecord, playerOneChoice, playerTwoChoice, gameResult, fightRecordCurrentIndex);*/

      fightRecord[fightRecordCurrentIndex] = record;

          // Increment the fight index counter and current history size
      fightRecordCurrentIndex = (fightRecordCurrentIndex + 1)  % fightRecordSize;

      if (fightRecordCurrentSize < fightRecordSize){
        fightRecordCurrentSize++;
      }
    }
  
  public void DisplayFightHistory () {
      int displayRecordIndex = 0;
      System.Console.WriteLine ("\nPodsumowanie:");
      for (int i = 0; i < fightRecordCurrentSize; i++){
        System.Console.WriteLine ("Game #{0}:\t{1}", i+1, fightRecord[displayRecordIndex].ToString());

    displayRecordIndex = (displayRecordIndex + 1) % fightRecordCurrentSize;


      }
    }




}