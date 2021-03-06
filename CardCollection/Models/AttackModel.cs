﻿using System;
using System.Collections.Generic;

namespace CardCollection.Models
{
    public class AttackModel
    {
        public Guid Id{ get; set; }
        public List<ElementModel> Cost { get; set; }
        public string Name { get; set; }
        public string Damage { get; set; }
        public string Description { get; set; }
    }
}
