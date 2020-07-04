using System;


public class Player {

  public string playerName;
  public int health = 10;
  public int currentGold = 0;

  public Player (string playerName)
  {
    this.playerName = playerName;
  }

  public void SetPlayerName () {
    System.Console.Write("Twoje imię to: ");
    playerName = System.Console.ReadLine();
  }

  public Player () {
    SetPlayerName();
  }



}

