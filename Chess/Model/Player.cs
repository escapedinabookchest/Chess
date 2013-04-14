using System;

namespace Chess.Model
{
    class Player
    {
        private Color _color;

        public Player(Color color)
        {
            Color = color;
        }

        public Color Color
        {
            get { return _color; }
            private set { _color = value; }
        } 
    }
}