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
                    newSquare.GetInitialPiece();
                    squares.Add(newSquare);
                }
            }

            Board board = new Board()
            {
                Squares = squares
            };

            return View(board);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}