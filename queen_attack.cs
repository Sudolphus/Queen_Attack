using System;
using Pieces.Queen;

namespace QueenMain
{
  public class QueenAttack
  {
    public static void Main()
    {
      int queenFile = 0;
      int queenRank = 0;
      do
      {
        Console.WriteLine("Input the File the Queen is on [1-8]");
        string stringQueenFile = Console.ReadLine();
        Console.WriteLine("Input the Rank the Queen is on [1-8]");
        string stringQueenRank = Console.ReadLine();
        queenFile = int.Parse(stringQueenFile);
        queenRank = int.Parse(stringQueenRank);
      }
      while (queenFile < 1 || queenFile > 8 || queenRank < 1 || queenRank > 8);
      int squareFile = 0;
      int squareRank = 0;
      do
      {
        Console.WriteLine("Input the File the Queen would like to attack [1-8]");
        string stringSquareFile = Console.ReadLine();
        Console.WriteLine("Input the Rank the Queen would like to attack [1-8]");
        string StringSquareRank = Console.ReadLine();
        squareFile = int.Parse(stringSquareFile);
        squareRank = int.Parse(StringSquareRank);
      }
      while (squareRank < 1 || squareRank > 8 || squareFile < 1 || squareFile > 8);

      Queen QueenPiece = new Queen(queenFile, queenRank);
      if (QueenPiece.CanQueenAttack(squareFile, squareRank))
      {
        Console.WriteLine("The queen can attack there!");
      }
      else
      {
        Console.WriteLine("The queen cannot attack there!");
      }
    }
  }
}