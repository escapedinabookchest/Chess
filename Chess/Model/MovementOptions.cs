using System;

namespace Chess.Model
{
    [Flags]
    enum MovementOptions
    {
        Forward = 1,
        Horizontal = 2,
        Diagonal = 4,
        Leap = 8,
        Single = 16,
        Full = 32
    }
}