using Chess.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    public class Knight
    {
        public static readonly Movement Movement = new Movement(false, false, false, false, true);

        public static bool ValidateMovement(Piece piece, MoveAttempt moveAttempt)
        {
            List<string> possibleValidCoordinates = GetPossibleVaildCoordinates(piece, moveAttempt);
            if (MoveCoordinatesAreValid(moveAttempt, possibleValidCoordinates))
            {
                if (AnyObstructions(moveAttempt))
                    return false;

                return true;
            }
            return false;
        }

        public static List<string> GetPossibleVaildCoordinates(Piece piece, MoveAttempt moveAttempt)
        {
            string currentHorizontalCoordinate = piece.CurrentSquare.HorizontalCoordinate;
            int currentVerticalCoordinate = piece.CurrentSquare.VerticalCoordinate;

            List<string> possibleValidCoordinates = new List<string>();
            Type type = typeof(BoardHelpers.HorizontalCoordinates);
            string maxAscendingHorizontalCoordinate = Enum.GetName(type, (int)Enum.Parse(type, currentHorizontalCoordinate) + 2);
            string minAscendingHorizontalCoordinate = Enum.GetName(type, (int)Enum.Parse(type, currentHorizontalCoordinate) + 1);
            string maxDescendingHorizontalCoordinate = Enum.GetName(type, (int)Enum.Parse(type, currentHorizontalCoordinate) - 2);
            string minDescendingHorizontalCoordinate = Enum.GetName(type, (int)Enum.Parse(type, currentHorizontalCoordinate) - 1);
            int maxAscendingVerticalCoordinate = currentVerticalCoordinate + 2;
            int minAscendingVerticalCoordinate = currentVerticalCoordinate + 1;
            int maxDescendingVerticalCoordinate = currentVerticalCoordinate - 2;
            int minDescendingVerticalCoordinate = currentVerticalCoordinate - 1;
            possibleValidCoordinates.Add($"{minAscendingHorizontalCoordinate}{maxAscendingVerticalCoordinate}");
            possibleValidCoordinates.Add($"{maxAscendingHorizontalCoordinate}{minAscendingVerticalCoordinate}");
            possibleValidCoordinates.Add($"{maxAscendingHorizontalCoordinate}{minDescendingVerticalCoordinate}");
            possibleValidCoordinates.Add($"{minAscendingHorizontalCoordinate}{maxDescendingVerticalCoordinate}");
            possibleValidCoordinates.Add($"{minDescendingHorizontalCoordinate}{maxDescendingVerticalCoordinate}");
            possibleValidCoordinates.Add($"{maxDescendingHorizontalCoordinate}{minDescendingVerticalCoordinate}");
            possibleValidCoordinates.Add($"{maxDescendingHorizontalCoordinate}{minAscendingVerticalCoordinate}");
            possibleValidCoordinates.Add($"{minDescendingHorizontalCoordinate}{maxAscendingVerticalCoordinate}");
            return possibleValidCoordinates;
        }

        private static bool MoveCoordinatesAreValid(MoveAttempt moveAttempt, List<string> possibleCoordinates) =>
            possibleCoordinates.Contains(moveAttempt.NewCoordinates);

        private static bool AnyObstructions(MoveAttempt moveAttempt)
        {
            return moveAttempt.PiecePlacementMap.Contains(moveAttempt.NewCoordinates);
        }
    }
}
