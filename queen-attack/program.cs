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
    }
  }
}