﻿using System;
namespace CardCollection.Models
{
    public class SetModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string IconUrl { get; set; }
    }
}
