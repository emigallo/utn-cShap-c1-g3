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
            Boolean winner = false;
          
          
                if (!board[x, i].Equals(""))
                {       
                    winner = true;

                    for(int j = 0; j < this.board.GetLength(0); j++)
                    {
                     winner &= board[x, i] == (board[x,j]);
                    }
                
                }
         
                return winner;

        }

        private Boolean CheckColumn(int y)
        {
            int i = 0;
            Boolean winner = false;


            if (!board[i, y].Equals(""))
            {
                winner = true;

                for (int j = 0; j < this.board.GetLength(0); j++)
                {
                    winner &= board[i, y] == (board[j, y]);
                }

            }

            return winner;

        }

        private Boolean CheckDiagonal()
        {

            int i = 0;
            Boolean winner = false;


            if (!board[i, i].Equals(""))
            {
                winner = true;

                for (int j = 0; j < this.board.GetLength(0); j++)
                {
                    winner &= board[i, i] == (board[j, j]);
                    //Todo hay que chequear la otra diagonal
                }

            }

            return winner;

        }


    }
}
