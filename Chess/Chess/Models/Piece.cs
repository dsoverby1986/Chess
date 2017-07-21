namespace Chess.Models
{
    public class Piece
    {
        public Piece(string name, Movement movement, bool castling)
        {
            Name = name;
            Movement = movement;
            IncludedInCastling = castling;
        }

        public string Name { get; set; }
        public Movement Movement { get; set; }
        public bool IncludedInCastling { get; set; }
    }
}