using System;
using System.Collections.Generic;

namespace Chess.Model
{
    class Loader
    {
        private Piece[,] _board;
        private LinkedList<Turn> _turns;

        public Loader(String filename) 
        {
            _board = new Piece[8, 8];
        }

        public Piece[,] Board
        {
            get { return _board; }
            private set { _board = value; }
        }

        public LinkedList<Turn> Turns
        {
            get { return _turns; }
            private set { _turns = value; }
        }
    }
}