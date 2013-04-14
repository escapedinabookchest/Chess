using System.Collections.Generic;

namespace Chess.Model
{
    class Game
    {
        private Player _currentPlayer;
        private Board _board;
        private LinkedList<Turn> _turns;
        
        public Game(Loader loader)
        {
            _currentPlayer = new Player(Color.White);
            _board = new Board(loader);
            _turns = loader.Turns;
        }
    }
}