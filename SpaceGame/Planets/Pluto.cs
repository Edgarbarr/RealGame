﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Planets
{
    public class Pluto : IPlanet
    {
        public string GetPlanetName()
        {
            return nameof(Name);
        }
        public PlanetName Name { get; set; }
        public Coordinate Coordinates { get; set; }
        public List<Item> ItemList { get; set; }

        public List<Item> GenerateItems()
        {
            throw new NotImplementedException();
        }
    }
}
