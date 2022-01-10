using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Models;
using System.Threading.Tasks;

namespace GUI.ViewModel
{
    public class TicTacToeViewModel
    {

        private Dictionary<string, Coordinates> _buttonMapping;
        Match match = new Match();

        public TicTacToeViewModel()
        {

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
           return match.PlayGame(x, y);
        }

        public Coordinates GetCoordinate(String key)
        {
            return _buttonMapping[key];
        }

        public String GetSymbol()
        {
            return match.GetSymbol();
        }
    }
}
