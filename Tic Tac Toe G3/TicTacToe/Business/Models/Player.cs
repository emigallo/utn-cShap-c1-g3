using System;

namespace Business.Models
{
    public class Player
    {
        public Player(String symbol,BoardGame board,String name)
        {
           this.Symbol = symbol;
           this.Board = board;
           this.Name = name;
        }

        public String Symbol { get; init; }

        private BoardGame Board { get; set; }

        private String Name { get; set; }

        public Boolean AddToken(int x,int y)
        {
            return this.Board.AddSymbolToBoard(x, y, this.Symbol); 
        }

        public Boolean AddToken(int x,int y, BoardView boardView)
        {
            if (this.AddToken(x, y))
            {
                boardView.UpdateAt(y, x, this.Symbol);
                return true;    
            }

            return false;

        }
    }
}
