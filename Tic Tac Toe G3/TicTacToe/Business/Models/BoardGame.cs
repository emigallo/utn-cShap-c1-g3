using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class BoardGame
    {
        String[,] board; //Tablero 

        public BoardGame()
        {
            this.board = new String[3, 3];
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    this.board[i, j] = new String("");
                }

            }

        }
        /// <summary>
        /// Agregar simbolo al tablero. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Boolean AddSymbolToBoard(int x , int y , String token)
        {
            if(!board[x, y].Equals("")) {

                return false; //Retornar futura excepcion.

            }
            board[x, y] = token;

            return true;

        }

        public Boolean CheckWinner()
        {
            Boolean winner = false;

            for (int i = 0; i < this.board.GetLength(0); i++)
            {
                winner |= CheckRow(i);
                winner |= CheckColumn(i);

            }

            return CheckDiagonal() || winner;

        }

        public Boolean CheckDrow()
        {

            foreach(String s in board)
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
            string firstPosition = board[x,0];
          
                if (!firstPosition.Equals(""))
                {        
                    while(firstPosition == board[x, ++i] && i<board.GetLength(x))
                    {
                       
                    }

                    if(firstPosition == board[x, i])
                {
                    return true;
                }
                }
         
                return false;

        }

        private Boolean CheckColumn(int y)
        {
            int i = 0;
            string firstPosition = board[0, y];

            if (!firstPosition.Equals(""))
            {
                while (firstPosition == board[++i, y])
                {
                    if (i == 2)
                        return true;
                }

            }

            return false;

        }

        private Boolean CheckDiagonal()
        {

            int i = 0;
            string firstPosition = board[0, 0];

            if (!firstPosition.Equals(""))
            {
                while (firstPosition == board[++i, i])
                {
                    if (i == 2)
                        return true;
                }

            }
            i = 0;
            firstPosition = board[0, 2];

            if (!firstPosition.Equals(""))
            {
                while (firstPosition == board[++i, 2-i])
                {
                    if (i == 2)
                        return true;
                }

            }

            return false;

        }


    }
}
