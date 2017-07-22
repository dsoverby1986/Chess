using Chess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.Extensions
{
    public static class SquareExtensions
    {
        private static readonly Dictionary<string, string> InitialPiecePlacementMap = new Dictionary<string, string>()
        {
            { "A1", "tower" },
            { "B1", "knight" },
            { "C1", "bishop" },
            { "D1", "queen" },
            { "E1", "king" },
            { "F1", "bishop" },
            { "G1", "knight" },
            { "H1", "tower" },
            { "A2", "pawn" },
            { "B2", "pawn" },
            { "C2", "pawn" },
            { "D2", "pawn" },
            { "E2", "pawn" },
            { "F2", "pawn" },
            { "G2", "pawn" },
            { "H2", "pawn" },
            { "A7", "pawn" },
            { "B7", "pawn" },
            { "C7", "pawn" },
            { "D7", "pawn" },
            { "E7", "pawn" },
            { "F7", "pawn" },
            { "G7", "pawn" },
            { "H7", "pawn" },
            { "A8", "tower" },
            { "B8", "knight" },
            { "C8", "bishop" },
            { "D8", "queen" },
            { "E8", "king" },
            { "F8", "bishop" },
            { "G8", "knight" },
            { "H8", "tower" }
        };

        public static void GetInitialPiece(this Square square)
        {
            string sqrCoordinates = square.HorizontalCoordinate + square.VerticalCoordinate;
            if (InitialPiecePlacementMap.Keys.Contains(sqrCoordinates))
                square.InitialPiece = InitialPiecePlacementMap[sqrCoordinates];
            else
                square.InitialPiece = null;
        }
    }
}