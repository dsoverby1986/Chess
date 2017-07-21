using System.Collections.Generic;

namespace Chess.Models
{
    public class Board
    {
        public const int Height = 8, Width = 8;
        public List<Square> Squares { get; set; }
    }
}