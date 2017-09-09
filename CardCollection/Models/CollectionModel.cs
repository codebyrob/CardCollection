using System;
namespace CardCollection.Models
{
    public class CollectionModel
    {
        public CardModel Card { get; set; }
        public HoloEnum HoloType { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
