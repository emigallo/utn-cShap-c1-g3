using System;
using System.Collections.Generic;
using Business.Models;

namespace GUI.ViewModel
{
    public class TicTacToeViewModel
    {
        private Dictionary<string, Coordinates> _buttonMapping;
        private Match _match;
        private String _namePlayer1 = "";
        private String _namePlayer2 = "";


        public TicTacToeViewModel(String namePlayer1,String namePlayer2)
        {
            this._namePlayer1 = namePlayer1;    
            this._namePlayer2 = namePlayer2;    
            _match = new Match(namePlayer1, namePlayer2);
            _buttonMapping = new Dictionary<string, Coordinates>();

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {              
                    _buttonMapping.Add((3 * i + j).ToString(), new Coordinates(i, j));
                }
            }
        }

        public Boolean PlayGame(int x, int y)
        {
           return _match.PlayGame(x, y);
        }

        public Coordinates GetCoordinate(String key)
        {
            return _buttonMapping[key];
        }

        public String GetSymbol()
        {
            return _match.GetSymbol();
        }
        
        public String GetCurrentPlayer()
        {
            return _match.GetCurrentPlayer();
        }

        public Boolean CheckDrow()
        {
            return _match.CheckDrow();
        }
        public void PlayAgain()
        {
            _match = new Match(this._namePlayer1, this._namePlayer2);
        }
        public Boolean CheckWinner()
        {
            return _match.CheckWinner();
        }
    }
}
