using System;
using System.Collections.Generic;

namespace CoinCombo
{
  public class CoinGame
  {
    private int _quarters = 0;
    private int _dimes = 0;
    private int _nickles = 0;
    private int _pennies = 0;

    public CoinGame()
    {

    }
    public int GetQuarters()
    {
      return _quarters;
    }
    public int GetDimes()
    {
      return _dimes;
    }
    public int GetNickles()
    {
      return _nickles;
    }
    public int GetPennies()
    {
      return _pennies;
    }

    public void GettingChange(int coin)
    {
      if (coin >= 25)
      {
        _quarters++;
        coin -= 25;
        GettingChange(coin);
     }
     else if (coin >= 10)
     {
       _dimes++;
       coin -= 10;
       GettingChange(coin);
     }
     else if (coin >= 5)
     {
       _nickles++;
       coin -=5;
       GettingChange(coin);
     }
     else if ( coin >= 1)
     {
       _pennies++;
       coin -=1;
       GettingChange(coin);
     }
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a number: ");
      string inputtedNumber = Console.ReadLine();
      int coin = int.Parse(inputtedNumber);
      CoinGame number = new CoinGame();
      number.GettingChange(coin);
      Console.WriteLine(number.GetQuarters() + "quarters");
       Console.WriteLine(number.GetDimes() + "dimes");
       Console.WriteLine(number.GetNickles() + "nickles");
      Console.WriteLine(number.GetPennies() + "pennies");
    }
  }
}

// "your change would be " +  number.GetQuarters() + "quarters" + number.GetDimes() + "dimes" + number.GetNickles() + "nickles" + number.GetPennies() + "pennies"
//
// for (int i = 0; i <= Coin; i++)
// {
//   if (Coin % 25 == 0)
// }
// if (Coin == 25)
// {
//   Console.WriteLine("Quarter");
// }
// else if (Coin == 10)
// {
//   Console.WriteLine("Dime");
// }
// else if (Coin == 5)
// {
//   Console.WriteLine("Nickle");
// }
// else if(Coin == 1)
// {
//   Console.WriteLine("Penny");
// }
