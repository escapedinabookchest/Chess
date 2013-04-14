using System;

namespace Chess.Model
{
    abstract class Piece
    {
        private Color _color;
        private bool _isMoved;

        public Piece(Color color)
        {
            Color = color;
            _isMoved = false;
        }

        public Color Color
        {
            get { return _color; }
            private set { _color = value; }
        }

        public bool IsMoved
        {
            get { return _isMoved; }
            set { _isMoved = value; }
        }

        public abstract String Name { get; }
        public abstract int Value { get; }
        public abstract MovementOptions Movement { get; }
    }

    sealed class King : Piece
    {
        public King(Color color) : base(color) { }

        public override String Name
        {
            get { return "king"; }
        }

        public override int Value
        {
            get { return 0; }
        }

        public override MovementOptions Movement
        {
            get 
            { 
                return 
                    MovementOptions.Horizontal |
                    MovementOptions.Diagonal |
                    MovementOptions.Single; 
            }
        }
    }

    sealed class Queen : Piece
    {
        public Queen(Color color) : base(color) { }

        public override String Name
        {
            get { return "queen"; }
        }

        public override int Value
        {
            get { return 9; }
        }

        public override MovementOptions Movement
        {
            get
            {
                return
                    MovementOptions.Horizontal |
                    MovementOptions.Diagonal |
                    MovementOptions.Full;
            }
        }
    }

    sealed class Rook : Piece
    {
        public Rook(Color color) : base(color) { }

        public override String Name
        {
            get { return "rook"; }
        }

        public override int Value
        {
            get { return 5; }
        }

        public override MovementOptions Movement
        {
            get
            {
                return
                    MovementOptions.Horizontal |
                    MovementOptions.Full;
            }
        }
    }

    sealed class Bishop : Piece
    {
        public Bishop(Color color) : base(color) { }

        public override String Name
        {
            get { return "bishop"; }
        }

        public override int Value
        {
            get { return 3; }
        }

        public override MovementOptions Movement
        {
            get
            {
                return
                    MovementOptions.Diagonal |
                    MovementOptions.Full;
            }
        }
    }

    sealed class Knight : Piece
    {
        public Knight(Color color) : base(color) { }

        public override String Name
        {
            get { return "knight"; }
        }

        public override int Value
        {
            get { return 3; }
        }

        public override MovementOptions Movement
        {
            get
            {
                return
                    MovementOptions.Leap |
                    MovementOptions.Single;
            }
        }
    }

    sealed class Pawn : Piece
    {
        public Pawn(Color color) : base(color) { }

        public override String Name
        {
            get { return "pawn"; }
        }

        public override int Value
        {
            get { return 1; }
        }

        public override MovementOptions Movement
        {
            get
            {
                return
                    MovementOptions.Forward |
                    MovementOptions.Single;
            }
        }
    }
}