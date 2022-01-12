using System;

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
        private String _lastSymbol;

        public Match(String namePlayer1, String namePlayer2)
        {
            this._boardGame = new BoardGame();
            this._player1 = new Player("X", this._boardGame,namePlayer1);
            this._player2 = new Player("O", this._boardGame,namePlayer2);
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

            if (!this._actualPlayer.AddToken(x, y, _boardView))
            {
                return false;
            }

            _boardView.PrintBoard();

            _lastSymbol = _actualPlayer.Symbol;

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

        public String GetSymbol()
        {
            return new String (this._lastSymbol);
        }

        public String GetCurrentPlayer()
        {
            return this._actualPlayer.Name;
        }

    }
}
