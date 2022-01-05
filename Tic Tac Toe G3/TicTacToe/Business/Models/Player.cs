using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Player
    {

        public Player(String symbol,BoardGame board)
        {
           this.Symbol = symbol;
           this.Board = board;
            
        }

        public String Symbol { get; init; }
        private BoardGame Board { get; set; } 


        public Boolean AddToken(int x,int y)
        {

            return this.Board.AddSymbolToBoard(x, y, this.Symbol); 

        }


    }
}
