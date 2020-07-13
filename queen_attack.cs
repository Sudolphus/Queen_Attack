using System;

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
      Console.WriteLine(queenFile.ToString() + queenRank.ToString());
    }
  }
}