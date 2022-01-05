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
        private Boolean _gameOver;
        private BoardView _boardView;


        public Match()
        {
            this._boardGame = new BoardGame();
            this._player1 = new Player("X", this._boardGame);
            this._player2 = new Player("O", this._boardGame);
            this._actualPlayer = this._player1;
            this._gameOver = false;
            _boardView = new BoardView();
        }

        public Boolean PlayGame(int x, int y)
        {
            if (this._gameOver)
            {
                throw new Exception("Juego terminado");
            }

            if (!(x >= 0 && x <= 2 && y >= 0 && y <= 2))

            {
                return false;
            }

            if (!this._actualPlayer.AddToken(x, y, _boardView))
            {
                return false;
            }

            _boardView.PrintBoard();

            if (this._boardGame.CheckDrow() || this._boardGame.CheckWinner())
            {
                this._gameOver = true;

                return this._gameOver;
            }

            SwitchPlayer();

            return false;
        }

        private void SwitchPlayer()
        {
            if (this._actualPlayer == this._player1)
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
