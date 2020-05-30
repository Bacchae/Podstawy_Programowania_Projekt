using System;

public class Main
{
    public static void Main (string[] args) 
    {

  Player playerOne = new Player("Player One");
  System.Console.WriteLine(playerOne.playerName);
  Player playerTwo = new Player();
  System.Console.WriteLine(playerTwo.playerName);
    }

    GamesRecord gamesRecord = new GamesRecord();
}