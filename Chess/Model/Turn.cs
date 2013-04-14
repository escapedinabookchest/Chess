using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    class Turn
    {
        private Notation _notation;
        private int _number;

        public Turn(int number, Notation notation)
        {
            Number = number;
            Notation = notation;
        }

        public int Number
        {
            get { return _number; }
            private set { _number = value; }
        }

        public Notation Notation
        {
            get { return _notation; }
            private set { _notation = value; }
        }

        public override string ToString()
        {
            return Number + " " + Notation;
        }
    }
}