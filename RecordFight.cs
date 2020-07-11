using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RecordFight : IRecord {

  string playerOneChoice;
  string playerTwoChoice;
  string gameResult;
  string turnRecord;


  public RecordFight (string playerOneChoice, string playerTwoChoice, string gameResult, string turnRecord) {
    this.playerOneChoice = playerOneChoice;
    this.playerTwoChoice = playerTwoChoice;
    this.gameResult = gameResult;
    this.turnRecord = turnRecord;
  }

  override public string ToString (){
    return string.Format("{0,20} : {1,-20}", playerOneChoice + " vs " + playerTwoChoice, gameResult);
  }



}