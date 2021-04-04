using System.Collections.Generic;

namespace TrickingLibrary.Models
{
    public class Trick : BaseModel<string>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DifficultyId { get; set; }
        // todo do we need this?
        public Difficulty Difficulty { get; set; }
        
        public IList<TrickRelationship> Prerequisites { get; set; } // easy olanlar yani öncesinde öğrenmen gerekenler
        public IList<TrickRelationship> Progressions { get; set; }  // hard olanlar yani sonrasında öğreneceklerin

        public IList<TrickCategory> TrickCategories { get; set; }
    }

    public class TrickCategory
    {
        public string TrickId { get; set; }
        public Trick Trick { get; set; }

        public string CategoryId { get; set; }
        public Category category { get; set; }
    }

    public class Category: BaseModel<string>
    {
        public string Description { get; set; }
        public IList<TrickCategory> Tricks { get; set; }
    }

    public class TrickRelationship
    {
        // Trick ler biribiriyle ilişkili olacaklar
        // easy, medium, hard şeklinde trick olacak.
        // örneğin bizim Trick medium. DOlayısıyla bu trick in Prerequisite ı easy i olan, Progression olanı ise hard olandır.
        
        public string PrerequisiteId { get; set; }
        public Trick Prerequisite { get; set; }
        public string ProgressionId { get; set; }
        public Trick Progression { get; set; }
    }

    public class Difficulty: BaseModel<string>
    {
        public string Description { get; set; }
        public IList<Trick> Tricks { get; set; }
    }
}