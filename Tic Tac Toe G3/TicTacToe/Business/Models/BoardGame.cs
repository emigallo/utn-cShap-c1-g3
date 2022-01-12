using System;

namespace Business.Models
{
    public class BoardGame
    {
        private String[,] _board; //Tablero 

        public BoardGame()
        {
            this._board = new String[3, 3];
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    this._board[i, j] = new String("");
                }

            }

        }

        public Boolean AddSymbolToBoard(int x , int y , String token)
        {
            if(!_board[x, y].Equals("")) 
            {
                return false; //Retornar futura excepcion.
            }
            _board[x, y] = token;

            return true;
        }

        public Boolean CheckWinner()
        {
            Boolean winner = false;

            for (int i = 0; i < this._board.GetLength(0); i++)
            {
                winner |= CheckRow(i);
                winner |= CheckColumn(i);
            }

            return CheckDiagonal() || winner;
        }

        public Boolean CheckDrow()
        {
            foreach(String s in _board)
            {
                if (String.IsNullOrWhiteSpace(s))
                {
                    return false;
                }
            }

            return true;

        }

        private Boolean CheckRow(int x)
        {     
            int i = 0;
            string firstPosition = _board[x,0];
          
                if (!firstPosition.Equals(""))
                {        
                    while(firstPosition == _board[x, ++i] && i<_board.GetLength(0)-1)
                    {
                       
                    }
                        if(firstPosition == _board[x, i])
                        {
                            return true;
                        }
                }
                
                return false;

        }

        private Boolean CheckColumn(int y)
        {
            int i = 0;
            string firstPosition = _board[0, y];

            if (!firstPosition.Equals(""))
            {
                while (firstPosition == _board[++i, y] && i < _board.GetLength(0)-1)
                {
                   
                }

                    if (firstPosition == _board[i, y])
                    {
                        return true;
                    }
            }

            return false;

        }

        private Boolean CheckDiagonal()
        {
            int i = 0;
            string firstPosition = _board[0, 0];

            if (!firstPosition.Equals(""))
            {
                while (firstPosition == _board[++i, i])
                {
                    if (i == 2)
                        return true;
                }

            }
            i = 0;
            firstPosition = _board[0, 2];

            if (!firstPosition.Equals(""))
            {
                while (firstPosition == _board[++i, 2-i])
                {
                    if (i == 2)
                        return true;
                }

            }

            return false;

        }


    }
}
