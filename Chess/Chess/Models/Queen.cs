using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    public class Queen
    {
        public static readonly Movement Movement = new Movement(false, false, true, true, false);

        public static bool ValidateMovement(Piece piece, MoveAttempt moveAttempt)
        {
            throw new NotImplementedException();
        }
    }
}
