using System;

public class Player {

  public string playerName;

  public Player (string playerName)
  {
    this.playerName = playerName;
  }

  public void SetPlayerName () {
    System.Console.Write("Please enter player name: ");
    playerName = System.Console.ReadLine();
  }

  public Player () {
    SetPlayerName();
  }


}

