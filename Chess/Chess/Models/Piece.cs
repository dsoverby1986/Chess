namespace Chess.Models
{
    public class Piece
    {
        public Piece(string name, string color, Movement movement, string initialSquare, bool castling)
        {
            Name = name;
            Color = color;
            Movement = movement;
            InitialSquare = initialSquare;
            IncludedInCastling = castling;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public string InitialSquare { get; set; }
        public Square CurrentSquare { get; set; }
        public Movement Movement { get; set; }
        public bool IncludedInCastling { get; set; }
    }
}