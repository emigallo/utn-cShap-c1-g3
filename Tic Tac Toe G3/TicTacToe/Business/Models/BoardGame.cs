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
        public void AddSymnolToBoard(int x , int y , Player player)
        {


        }

        public void CheckWinner()
        {


        }

        
    }
}
