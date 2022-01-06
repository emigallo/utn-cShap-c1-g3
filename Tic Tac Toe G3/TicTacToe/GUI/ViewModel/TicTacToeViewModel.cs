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
        private Dictionary<string, Tuple<int, int>> _buttonMapping;
        Match match = new Match();

        public TicTacToeViewModel()
        {
            _buttonMapping = new Dictionary<string, Tuple<int, int>>();
            _buttonMapping.Add("0", Tuple.Create(0, 0));
            _buttonMapping.Add("1", Tuple.Create(0, 1));
            _buttonMapping.Add("2", Tuple.Create(0, 2));
            _buttonMapping.Add("3", Tuple.Create(1, 0));
            _buttonMapping.Add("4", Tuple.Create(1, 1));
            _buttonMapping.Add("5", Tuple.Create(1, 2));
            _buttonMapping.Add("6", Tuple.Create(2, 0));
            _buttonMapping.Add("7", Tuple.Create(2, 1));
            _buttonMapping.Add("8", Tuple.Create(2, 2));
        }

        public Boolean PlayGame(int x, int y)
        {
           return match.PlayGame(x, y);
        }

        public Tuple<int, int> SendKey(String key)
        {
            return _buttonMapping[key];
        }

        public String GetSymbol()
        {
            return match.GetSymbol();
        }
    }
}
