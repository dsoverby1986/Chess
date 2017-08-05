using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.Models
{
    public static class Movements
    {
        public static Movement GetMovementFor(string pieceName)
        {
            Movement movement = null;
            switch (pieceName)
            {
                case "tower":
                    movement = Rook.Movement;
                    break;
                case "knight":
                    movement = Knight.Movement;
                    break;
                case "bishop":
                    movement = Bishop.Movement;
                    break;
                case "queen":
                    movement = Queen.Movement;
                    break;
                case "king":
                    movement = King.Movement;
                    break;
                case "pawn":
                    movement = Pawn.Movement;
                    break;
            }
            return movement;
        }

        public static bool ValidateMovement (this Piece piece, MoveAttempt moveAttempt)
        {
            bool valid = false;
            switch (piece.Name)
            {
                case "tower":
                    valid = Rook.ValidateMovement(piece, moveAttempt);
                    break;
                case "knight":
                    valid = Knight.ValidateMovement(piece, moveAttempt);
                    break;
                case "bishop":
                    valid = Bishop.ValidateMovement(piece, moveAttempt);
                    break;
                case "queen":
                    valid = Queen.ValidateMovement(piece, moveAttempt);
                    break;
                case "king":
                    valid = King.ValidateMovement(piece, moveAttempt);
                    break;
                case "pawn":
                    valid = Pawn.ValidateMovement(piece, moveAttempt);
                    break;
            }
            return valid;
        }
    }
}