using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    public static class Pawn
    {
        public static readonly Movement Movement = new Movement(true, true, true, true, false);
        
        public static bool ValidateMovement(Piece piece, MoveAttempt moveAttempt)
        {
            return true;
        }
    }
}
