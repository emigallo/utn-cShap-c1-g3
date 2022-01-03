using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Match
    {
        private BoardGame _boradGame;
        private Player _player1;
        private Player _player2;


        public Match()
        {
            this._boradGame = new BoardGame();
            this._player1 = new Player("X");
            this._player2 = new Player("O");
        }

        public void PlayGame()
        {
            

        }

        

    }
}
