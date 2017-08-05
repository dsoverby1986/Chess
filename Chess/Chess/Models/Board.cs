using System.Collections.Generic;
using Chess.Helpers;

namespace Chess.Models
{
    public class Board
    {
        public const int Height = 8, Width = 8;
        public char[] HorizontalIndex { get { return new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' }; } }
        public List<Square> Squares { get; set; }
        public List<Piece> Pieces { get; set; }
    }
}