using System;

namespace Chess.Model
{
    class Board
    {
        private Piece[,] _grid;

        public Board(Loader loader)
        {  
            _grid = loader.Board;
        }

        public Piece[,] Grid
        {
            get { return _grid; }
            private set { _grid = value; }
        }

        public Piece selectPiece(int x, int y)
        {
            if ((x < 1 || x > 8) || (y < 1 || y > 8))
            {
                throw new ArgumentOutOfRangeException("A piece cannot be placed outside the board.");
            }

            return Grid[x, y];
        }

        public void addPiece(Piece piece, int x, int y)
        {
            if(selectPiece(x, y) != null) {
                throw new ArgumentException("There is already a piece on that square.");
            }

            Grid[x, y] = piece;
        }

        public void removePiece(int x, int y)
        {
            if (selectPiece(x, y) == null)
            {
                throw new ArgumentException("There is no piece on that square.");
            }

            Grid[x, y] = null;
        }
    }
}