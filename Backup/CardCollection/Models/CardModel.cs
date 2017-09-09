using System;
using System.Collections.Generic;

namespace CardCollection.Models
{
    public class CardModel
    {
        public string Name { get; set; }
	    public int HP { get; set; }
		public string ImageUrl { get; set; }
		public string Description { get; set; }
        public RarityEnum Rarity { get; set; }
	    public SetModel Set { get; set; }
		public int CardNumber { get; set; }
		public List<ElementModel> Elements { get; set; }
		public List<AttackModel> Attacks { get; set; }
		public List<WeaknessModel> Weaknesses { get; set; }
		public List<ResistanceModel> Resistance { get; set; }
		public List<ElementModel> RetreatCost { get; set; }
    }
}
