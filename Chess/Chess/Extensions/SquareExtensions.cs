using Chess.Models;
using Chess.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Chess.Helpers.BoardHelpers;

namespace Chess.Extensions
{
    public static class SquareExtensions
    {
        private static readonly Dictionary<string, Piece> InitialPiecePlacementMap = new Dictionary<string, Piece>()
        {
            { "A1", new Piece("tower", "white", new Movement(false, false, true, false, false), "A1", true) },
            { "B1", new Piece("knight", "white", new Movement(false, false, false, false, true), "B1", false) },
            { "C1", new Piece("bishop", "white", new Movement(false, false, false, true, false), "C1", false) },
            { "D1", new Piece("queen", "white", new Movement(false, false, true, true, false), "D1", false) },
            { "E1", new Piece("king", "white", new Movement(true, false, true, true, false), "E1", true) },
            { "F1", new Piece("bishop", "white", new Movement(false, false, false, true, false), "F1", false) },
            { "G1", new Piece("knight", "white", new Movement(false, false, false, false, true), "G1", false) },
            { "H1", new Piece("tower", "white", new Movement(false, false, true, false, false), "H1", true) },
            { "A2", new Piece("pawn", "white", new Movement(true, true, true, true, false), "A2", false) },
            { "B2", new Piece("pawn", "white", new Movement(true, true, true, true, false), "B2", false) },
            { "C2", new Piece("pawn", "white", new Movement(true, true, true, true, false), "C2", false) },
            { "D2", new Piece("pawn", "white", new Movement(true, true, true, true, false), "D2", false) },
            { "E2", new Piece("pawn", "white", new Movement(true, true, true, true, false), "E2", false) },
            { "F2", new Piece("pawn", "white", new Movement(true, true, true, true, false), "F2", false) },
            { "G2", new Piece("pawn", "white", new Movement(true, true, true, true, false), "G2", false) },
            { "H2", new Piece("pawn", "white", new Movement(true, true, true, true, false), "H2", false) },
            { "A7", new Piece("pawn", "black", new Movement(true, true, true, true, false), "A7", false) },
            { "B7", new Piece("pawn", "black", new Movement(true, true, true, true, false), "B7", false) },
            { "C7", new Piece("pawn", "black", new Movement(true, true, true, true, false), "C7", false) },
            { "D7", new Piece("pawn", "black", new Movement(true, true, true, true, false), "D7", false) },
            { "E7", new Piece("pawn", "black", new Movement(true, true, true, true, false), "E7", false) },
            { "F7", new Piece("pawn", "black", new Movement(true, true, true, true, false), "F7", false) },
            { "G7", new Piece("pawn", "black", new Movement(true, true, true, true, false), "G7", false) },
            { "H7", new Piece("pawn", "black", new Movement(true, true, true, true, false), "H7", false) },
            { "A8", new Piece("tower", "black", new Movement(false, false, true, false, false), "A8", true) },
            { "B8", new Piece("knight", "black", new Movement(false, false, false, false, true), "B8", false) },
            { "C8", new Piece("bishop", "black", new Movement(false, false, false, true, false), "C8", false) },
            { "D8", new Piece("queen", "black", new Movement(false, false, true, true, false), "D8", false) },
            { "E8", new Piece("king", "black", new Movement(true, false, true, true, false), "E8", true) },
            { "F8", new Piece("bishop", "black", new Movement(false, false, false, true, false), "F8", false) },
            { "G8", new Piece("knight", "black", new Movement(false, false, false, false, true), "G8", false) },
            { "H8", new Piece("tower", "black", new Movement(false, false, true, false, false), "H8", true) }
        };

        public static void GetInitialPiece(this Square square, out Piece piece)
        {
            string sqrCoordinates = square.HorizontalCoordinate + square.VerticalCoordinate;
            if (InitialPiecePlacementMap.Keys.Contains(sqrCoordinates))
                square.InitialPiece = InitialPiecePlacementMap[sqrCoordinates];
            else
                square.InitialPiece = null;

            if (square.InitialPiece != null)
                piece = InitialPiecePlacementMap[$"{square.HorizontalCoordinate}{square.VerticalCoordinate}"];
            //piece = BoardSetupPieceMap[new Tuple<int, int>((int)Enum.Parse(typeof(HorizontalCoordinates), square.HorizontalCoordinate), square.VerticalCoordinate)];
            else
                piece = null;
        }
    }
}