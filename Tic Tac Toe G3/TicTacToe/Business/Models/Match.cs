using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Match
    {
        private BoardGame _boardGame;
        private Player _player1;
        private Player _player2;
        private Player _actualPlayer;


        public Match()
        {
            this._boardGame = new BoardGame();
            this._player1 = new Player("X", this._boardGame);
            this._player2 = new Player("O", this._boardGame);
            this._actualPlayer = this._player1;   
        }

        public void PlayGame(int x,int y)
        {
            if (x >= 0 && x <= 2 && y >= 0 && y <= 2)

            {
                if (this._actualPlayer.AddToken(x, y))
                {
                    SwitchPlayer();
                }
            }
        }

        private void SwitchPlayer()
        {
            if(this._actualPlayer == this._player1)
            {
                this._actualPlayer = this._player2;
            }
            else
            {
                this._actualPlayer = this._player1;
            }

        }

        

    }
}
