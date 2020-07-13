namespace Pieces.Queen
{
  public class Queen
  {
    private int _queenFile;
    private int _queenRank;

    public Queen(int queenFile, int queenRank)
    {
      _queenFile = queenFile;
      _queenRank = queenRank;
    }

    public bool CanQueenAttack(int squareFile, int squareRank)
    {
      if (AttackAlongFile(squareFile))
      {
        return true;
      }
      else if (AttackAlongRank(squareRank))
      {
        return true;
      }
      else if (AttackAlongDiagonal(squareFile, squareRank))
      {
        return true;
      }
      return false;
    }

    private bool AttackAlongFile(int squareFile)
    {
      return (squareFile == _queenFile);
    }

    private bool AttackAlongRank(int squareRank)
    {
      return (squareRank == _queenRank);
    }

    private bool AttackAlongDiagonal(int squareFile, int squareRank)
    {
      int fileDifference = _queenFile - squareFile;
      int rankDifference = _queenRank - squareRank;
      if (fileDifference == rankDifference || fileDifference * -1 == rankDifference)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}