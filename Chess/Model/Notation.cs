using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    class Notation
    {
        private String _notation;

        public Notation(String notation)
        {
            _notation = notation;
        }

        public override string ToString()
        {
            return _notation;
        }
    }
}