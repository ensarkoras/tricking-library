namespace TrickingLibrary.Models
{
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
}