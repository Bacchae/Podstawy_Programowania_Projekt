using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RecordFight {

  string playerOneChoice;
  string playerTwoChoice;
  string result;


  public RecordFight (string playerOneChoice, string playerTwoChoice, string result) {
    this.playerOneChoice = playerOneChoice;
    this.playerTwoChoice = playerTwoChoice;
    this.result = gameResult;
// turnRecord;
  }

  override public string ToString (){
    return string.Format("{0,20} : {1,-20}", playerOneChoice + " vs " + playerTwoChoice, result);
  }



}