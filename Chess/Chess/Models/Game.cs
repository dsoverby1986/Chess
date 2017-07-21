using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.Models
{
    public class Game
    {
        public ApplicationUser Player1 { get; set; }
        public ApplicationUser Player2 { get; set; }
        public Board Board { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? StopDateTime { get; set; }
        public DateTime? CompleteDateTime { get; set; }
    }
}