using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Models
{
    public static class Rook
    {
        public static readonly Movement Movement = new Movement(false, false, true, false, false);
        
        public static bool ValidateMovement (Piece piece, MoveAttempt moveAttempt)
        {
            char currentHorizontalIndex = moveAttempt.CurrentCoordinates.Substring(1, 1).ToCharArray()[0];
            int currentVerticalIndex = Int32.Parse(moveAttempt.CurrentCoordinates.Substring(0, 1));
            char newHorizontalIndex = moveAttempt.NewCoordinates.Substring(1, 1).ToCharArray()[0];
            int newVerticalIndex = Int32.Parse(moveAttempt.NewCoordinates.Substring(0, 1));

            bool verticalMove = (currentVerticalIndex != newVerticalIndex) && (currentHorizontalIndex == newHorizontalIndex);
            bool horizontalMove = (currentHorizontalIndex != newHorizontalIndex) && (currentVerticalIndex == newVerticalIndex);

            if (!verticalMove && !horizontalMove)
                return false;
            else
            {
                bool pieceInPath = false;
                int index = 0;
                if (verticalMove)
                {
                    bool positiveMove = currentVerticalIndex < newVerticalIndex;
                    while (!pieceInPath)
                    {
                        string otherPieceLocation = moveAttempt.PiecePlacementMap[index];
                        int otherPieceVerticalIndex = Int32.Parse(otherPieceLocation.Substring(0, 1));
                        char otherPieceHorizontalIndex = otherPieceLocation.Substring(1, 1).ToCharArray()[0];
                        if(otherPieceHorizontalIndex == currentHorizontalIndex)
                        {
                            if (positiveMove)
                            {
                                if(otherPieceVerticalIndex < newVerticalIndex)
                                {
                                    pieceInPath = true;
                                }
                            }
                            else
                            {
                                if(otherPieceVerticalIndex > newVerticalIndex)
                                {
                                    pieceInPath = true;
                                }
                            }
                        }
                        index++;
                    }
                }
                else
                {
                    bool ascendingMove = currentHorizontalIndex < newHorizontalIndex;
                    while (!pieceInPath)
                    {
                        string otherPieceLocation = moveAttempt.PiecePlacementMap[index];
                        int otherPieceVerticalIndex = Int32.Parse(otherPieceLocation.Substring(0, 1));
                        char otherPieceHorizontalIndex = otherPieceLocation.Substring(1, 1).ToCharArray()[0];
                        if(otherPieceVerticalIndex == currentVerticalIndex)
                        {
                            if (ascendingMove)
                            {
                                if(otherPieceHorizontalIndex < newHorizontalIndex)
                                {
                                    pieceInPath = true;
                                }
                            }
                            else
                            {
                                if(otherPieceHorizontalIndex > newHorizontalIndex)
                                {
                                    pieceInPath = true;
                                }
                            }
                        }
                        index++;
                    }
                }
                return pieceInPath ? false : true;
            }
        }
    }
}