using System;

public class Player {

  public string playerName;

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

