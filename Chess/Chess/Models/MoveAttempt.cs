using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    public class MoveAttempt
    {
        public MoveAttempt(string currentCoordinates, string newCoordinates, string newCoordPieceColor, List<string> piecePlacementMap)
        {
            CurrentCoordinates = currentCoordinates;
            NewCoordinates = newCoordinates;
            NewCoordPieceColor = newCoordPieceColor;
            PiecePlacementMap = piecePlacementMap;
        }
        public string CurrentCoordinates { get; set; }
        public string NewCoordinates { get; set; }
        public string NewCoordPieceColor { get; set; }
        public List<string> PiecePlacementMap { get; set; }
    }
}
