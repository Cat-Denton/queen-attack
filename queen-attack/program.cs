using System;
using System.Collections.Generic;
using Chess.Models;

namespace Chess
{
  public class Program
  {
    public static void Main()
    {
      int[] whiteQueenPos = {4,1};
      Queen queen = new Queen(whiteQueenPos, false, "white");
      Console.WriteLine("the " + queen.Color + " Queen has entered the playing field");
      Console.WriteLine(Convert.ToString(queen.Position[0]) + ", " + Convert.ToString(queen.Position[1]) + " are the current coordinates of the " + queen.Color + " queen");
      Console.WriteLine("This piece has been captured? " + Convert.ToString(queen.Captured));
    }
  }
}