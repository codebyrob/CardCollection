﻿using System;
namespace CardCollection.Models
{
    public class WeaknessModel
    {
        public Guid Id{ get; set; }
        public ElementModel Element { get; set; }
        public int Multiplier { get; set; }
    }
}
