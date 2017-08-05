using Chess.Models;
using Chess.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Chess.Helpers.BoardHelpers;

namespace Chess.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Square> squares = new List<Square>();
            List<Piece> pieces = new List<Piece>();
            for(int i = 1; i <= Board.Height; i++)
            {
                for(int j = 1; j <= Board.Width; j++)
                {
                    Square newSquare = new Square();
                    if ((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0))
                        newSquare.White = true;
                    else
                        newSquare.White = false;
                    newSquare.VerticalCoordinate = i;
                    newSquare.HorizontalCoordinate = Enum.GetName(typeof(HorizontalCoordinates), j);
                    Piece newPiece = null;
                    newSquare.GetInitialPiece(out newPiece);
                    squares.Add(newSquare);
                    if (newPiece != null)
                        pieces.Add(newPiece);
                }
            }

            Board board = new Board()
            {
                Squares = squares,
                Pieces = pieces
            };

            return View(board);
        }

        public ActionResult ValidateMove(string pieceName, string color, string initialCoordinates, bool includedInCastling, string currentCoordinates, string newCoordinates, string newCoordPieceColor, List<string> piecePlacementMap)
        {
            Piece piece = new Piece(pieceName, color, Movements.GetMovementFor(pieceName), initialCoordinates, includedInCastling);
            bool valid = piece.ValidateMovement(new MoveAttempt(currentCoordinates, newCoordinates, newCoordPieceColor, piecePlacementMap));
            return Json(new { valid = valid }, JsonRequestBehavior.AllowGet);
        }
    }
}