using Chess.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Chess.Helpers.BoardHelpers;

namespace Chess.Controllers
{
    public class GameController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Game
        public ActionResult Index()
        {
            ApplicationUser user = db.Users.Find(User.Identity.GetUserId());
            List<Square> squares = GetBoardSquares();
            Game game = new Game()
            {
                Player1 = user,
                Board = new Board()
                {
                    Squares = squares
                }
            };
            return View(game);
        }
    }
}