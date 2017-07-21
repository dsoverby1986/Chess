using Chess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.Helpers
{
    public class BoardHelpers
    {
        public enum HorizontalCoordinates
        {
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H
        };

        public enum VerticalCoordinates
        {
            _1,
            _2,
            _3,
            _4,
            _5,
            _6,
            _7,
            _8
        };

        public static Dictionary<Tuple<int, int>, Piece> BoardSetupPieceMap = new Dictionary<Tuple<int, int>, Piece>()
        {
            { new Tuple<int, int>((int)HorizontalCoordinates.A, (int)VerticalCoordinates._1), new Piece("Rook", new Movement(false, false, true, false, false), true) },
            { new Tuple<int, int>((int)HorizontalCoordinates.B, (int)VerticalCoordinates._1), new Piece("Knight", new Movement(false, false, false, false, true), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.C, (int)VerticalCoordinates._1), new Piece("Bishop", new Movement(false, false, false, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.D, (int)VerticalCoordinates._1), new Piece("King", new Movement(true, false, true, true, false), true) },
            { new Tuple<int, int>((int)HorizontalCoordinates.E, (int)VerticalCoordinates._1), new Piece("Queen", new Movement(false, false, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.F, (int)VerticalCoordinates._1), new Piece("Bishop", new Movement(false, false, false, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.G, (int)VerticalCoordinates._1), new Piece("Knight", new Movement(false, false, false, false, true), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.H, (int)VerticalCoordinates._1), new Piece("Rook", new Movement(false, false, true, false, false), true) },
            { new Tuple<int, int>((int)HorizontalCoordinates.A, (int)VerticalCoordinates._2), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.B, (int)VerticalCoordinates._2), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.C, (int)VerticalCoordinates._2), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.D, (int)VerticalCoordinates._2), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.E, (int)VerticalCoordinates._2), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.F, (int)VerticalCoordinates._2), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.G, (int)VerticalCoordinates._2), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.H, (int)VerticalCoordinates._2), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.A, (int)VerticalCoordinates._7), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.B, (int)VerticalCoordinates._7), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.C, (int)VerticalCoordinates._7), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.D, (int)VerticalCoordinates._7), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.E, (int)VerticalCoordinates._7), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.F, (int)VerticalCoordinates._7), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.G, (int)VerticalCoordinates._7), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.H, (int)VerticalCoordinates._7), new Piece("Pawn", new Movement(true, true, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.A, (int)VerticalCoordinates._8), new Piece("Rook", new Movement(false, false, true, false, false), true) },
            { new Tuple<int, int>((int)HorizontalCoordinates.B, (int)VerticalCoordinates._8), new Piece("Knight", new Movement(false, false, false, false, true), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.C, (int)VerticalCoordinates._8), new Piece("Bishop", new Movement(false, false, false, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.D, (int)VerticalCoordinates._8), new Piece("King", new Movement(true, false, true, true, false), true) },
            { new Tuple<int, int>((int)HorizontalCoordinates.E, (int)VerticalCoordinates._8), new Piece("Queen", new Movement(false, false, true, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.F, (int)VerticalCoordinates._8), new Piece("Bishop", new Movement(false, false, false, true, false), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.G, (int)VerticalCoordinates._8), new Piece("Knight", new Movement(false, false, false, false, true), false) },
            { new Tuple<int, int>((int)HorizontalCoordinates.H, (int)VerticalCoordinates._8), new Piece("Rook", new Movement(false, false, true, false, false), true) }
        };

        public static List<Square> GetBoardSquares()
        {
            List<Square> squares = new List<Square>();

            for (var i = Board.Height; i >= 1; i--)
            {
                for(int j = 1; j <= Board.Width; j++)
                {
                    Square newSquare = new Square();

                    if (i % 2 == 0 && j % 2 != 0)
                        newSquare.White = true;

                    newSquare.VerticalCoordinate = i;
                    newSquare.HorizontalCoordinate = j;
                    Piece initialPiece = BoardSetupPieceMap[new Tuple<int, int>(j, i)];
                    newSquare.InitialPiece = initialPiece;
                    newSquare.CurrentPiece = initialPiece;
                    squares.Add(newSquare);
                }
            }

            return squares;
        }
    }
}