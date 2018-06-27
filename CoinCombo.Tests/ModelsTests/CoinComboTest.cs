using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombo;
using System.Collections.Generic;

namespace CoinCombo.Test
{
  [TestClass]
  public class CoinComboTest
  {
    // [TestMethod]
    // public void EnteredString()
    // {
    //   CoinGame number = new CoinGame();
    //   //Arrange
    //   string expectedResult = "Please put in a number";
    //   string testValue = string;
    //   Assert.AreEqual(expectedResult, number.Main(testValue));
    // }
    [TestMethod]
    public void TwoDimes()
    {
      CoinGame number = new CoinGame();
      int expectedResult = 2;
      int coin = 20;
      number.GettingChange(coin);
      Assert.AreEqual(expectedResult, number.GetDimes());
    }
  }
}
