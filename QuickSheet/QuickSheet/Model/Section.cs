﻿using System.Collections.Generic;

namespace QuickSheet.Model
{
    public class Section
    {
        public Section(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public List<Cheat> Cheats { get; } = new List<Cheat>();
    }
}