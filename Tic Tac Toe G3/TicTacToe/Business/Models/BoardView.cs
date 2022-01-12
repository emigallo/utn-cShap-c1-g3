using System;
using System.Collections.Generic;

namespace Business.Models
{

    public class BoardView
    {
        private string _boardView = "    1 . 2 . 3 .\n  +---+---+---+\n1 |   |   |   |\n  +---+---+---+\n2 |   |   |   |\n  +---+---+---+\n3 |   |   |   |\n  +---+---+---+\n";
        private Dictionary<Tuple<int, int>, int> _mapping;
        public BoardView()
        {
            this._mapping = new Dictionary<Tuple<int, int>, int>();
            _mapping.Add(Tuple.Create(0, 0), 0x24);
            _mapping.Add(Tuple.Create(0, 1), 0x44);
            _mapping.Add(Tuple.Create(0, 2), 0x64);
            _mapping.Add(Tuple.Create(1, 0), 0x28);
            _mapping.Add(Tuple.Create(1, 1), 0x48);
            _mapping.Add(Tuple.Create(1, 2), 0x68);
            _mapping.Add(Tuple.Create(2, 0), 0x2c);
            _mapping.Add(Tuple.Create(2, 1), 0x4c);
            _mapping.Add(Tuple.Create(2, 2), 0x6c);
        }

        public void UpdateAt(int x, int y, String token)
        {
            int map = this._mapping[Tuple.Create(x, y)];
            _boardView = _boardView.Remove(map, 1).Insert(map, token);
        }

        public void PrintBoard()
        {
            Console.WriteLine(this._boardView);
        }
    }
}
