namespace Chess.Models
{
    public class Movement
    {
        public Movement(bool single, bool @double, bool linear, bool diagonal, bool lShape)
        {
            SingleSquare = single;
            InitialDouble = @double;
            Linear = linear;
            Diagonal = diagonal;
            LShape = lShape;
        }

        public bool SingleSquare { get; set; }
        public bool InitialDouble { get; set; }
        public bool Linear { get; set; }
        public bool Diagonal { get; set; }
        public bool LShape { get; set; }
    }
}