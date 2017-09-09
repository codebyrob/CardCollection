using System;
namespace CardCollection.Models
{
    public class ResistanceModel
    {
        public Guid Id{ get; set; }
        public ElementModel Element { get; set; }
        public int Reduction { get; set; }
    }
}
