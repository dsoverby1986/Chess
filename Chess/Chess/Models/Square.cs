using System.Collections.Generic;
using Chess.Helpers;

namespace Chess.Models
{
    public class Square
    {
        public string HorizontalCoordinate { get; set; }
        public int VerticalCoordinate { get; set; }
        public bool White { get; set; }
        public Piece InitialPiece { get; set; }
        public Piece CurrentPiece { get; set; }
    }
}