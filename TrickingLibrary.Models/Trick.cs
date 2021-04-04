using System.Collections.Generic;

namespace TrickingLibrary.Models
{
    public class Trick : BaseModel<string>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Difficulty { get; set; }
        
        public IList<TrickRelationship> Prerequisites { get; set; } // easy olanlar yani öncesinde öğrenmen gerekenler
        public IList<TrickRelationship> Progressions { get; set; }  // hard olanlar yani sonrasında öğreneceklerin

        public IList<TrickCategory> TrickCategories { get; set; }
    }
}