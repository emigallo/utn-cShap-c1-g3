using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class BoardGame
    {
            
        String[,] board = new String[3,3]; //Tablero 

        public BoardGame()
        {
            

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
            return this.board[x,0] == this.board[x,1] && this.board[x, 1] == this.board[x,2];

        }

        private Boolean CheckColumn(int y)
        {
            return this.board[0, y] == this.board[1, y] && this.board[1, y] == this.board[2, y];

        }

        private Boolean CheckDiagonal()
        {

            return (this.board[0, 0] == this.board[1, 1] && this.board[2, 2] == this.board[1, 1]) || (this.board[0, 2] == this.board[1, 1] && this.board[2, 0] == this.board[1, 1]);

        }


    }
}
