﻿using System.Collections;
using System.Collections.Generic;

namespace FootballApplication
{
    public class Team
    {
        public int Id { get; set; }
        public string  Ad { get; set; }
        public short KurulusYili { get; set; }

        
        public ICollection<Player> Players { get; set; }
        public ICollection<Sponsor> Sponsors { get; set; }
    }
}
