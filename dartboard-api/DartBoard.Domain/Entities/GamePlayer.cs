﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DartBoard.Domain.Entities
{
    public class GamePlayer
    {
        public Guid GameId { get; set; }
        public Game Game { get; set; }
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
