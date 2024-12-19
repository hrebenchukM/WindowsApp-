public class Model
{
    public bool PlayerX { get; set; }
    public bool FirstPlayerX { get; set; }
    public bool Easy { get; set; }
    public bool GameStarted { get; set; }
    public List<int> gameBoard { get; private set; }

    public Model()
    {
        gameBoard = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        PlayerX = true;
        FirstPlayerX = true;
        Easy = true;
        GameStarted = false;
    }

    public bool MakeMove(int index)
    {
        if(!GameStarted) return false;
        if (gameBoard[index] == 0)
        {
            gameBoard[index] = PlayerX ? 1 : 2;
            PlayerX = !PlayerX;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        for (int i = 0; i < gameBoard.Count; i++)
        {
            gameBoard[i] = 0;
        }
        GameStarted = false;
    }

    public bool CheckGameState()
    {
        return CheckWin() || CheckDraw();
    }

    public bool CheckLine(int i1, int i2, int i3)
    {
        return gameBoard[i1] != 0 &&
               gameBoard[i1] == gameBoard[i2] &&
               gameBoard[i1] == gameBoard[i3];
    }

    public bool CheckDraw()
    {
        return gameBoard.All(x => x != 0);
    }

    public bool CheckWin()
    {
        return CheckLine(0, 1, 2) ||
               CheckLine(3, 4, 5) ||
               CheckLine(6, 7, 8) ||
               CheckLine(0, 3, 6) ||
               CheckLine(1, 4, 7) ||
               CheckLine(2, 5, 8) ||
               CheckLine(0, 4, 8) ||
               CheckLine(2, 4, 6);
    }

    public List<int> AvailableMoves()
    {
        List<int> moves = new List<int>();

        for (int i = 0; i < gameBoard.Count; i++)
        {
            if (gameBoard[i] == 0)
            {
                moves.Add(i);
            }
        }

        return moves;
    }
    public void ComputerMove()
    {
        if (Easy)
        {
            RandomMove();
        }
        else
        {
            SmartMove();
        }
    }


    private void RandomMove()
    {
        var rnd = new Random();
        var moves = AvailableMoves();
        if (moves.Count > 0)
        {
            int index = moves[rnd.Next(moves.Count)];
            gameBoard[index] = PlayerX ? 1 : 2; 
            PlayerX = !PlayerX; 
        }
    }

    private void SmartMove()
    {
        // Попытка выиграть  
        foreach (int index in AvailableMoves())
        {
            gameBoard[index] = 2;
            if (CheckWin())
            {
                PlayerX = true;
                return;
            }
            gameBoard[index] = 0;
        }

        // Попытка блокировки хода игрока  
        foreach (int index in AvailableMoves())
        {
            gameBoard[index] = 1;
            if (CheckWin())
            {
                gameBoard[index] = 2;
                PlayerX = true; 
                return;
            }
            gameBoard[index] = 0;
        }

        RandomMove();
    }

}