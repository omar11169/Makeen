using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventom.Models
{
    public class Rating
    {
        [Key] 
        public int RatingID { get; set; }

        [ForeignKey("EventId")]
        public int EventId { get; set; }

        [ForeignKey("Volunteer")]
        public int VolunteerId { get; set; }

        [ForeignKey("User")]
        public int CreatorId { get; set; }

        public int PunctuallityRating { get; set; }

        public int QuakityRating { get; set; }

        public int TeamWorkRating { get; set; }     

        public int initiativeRating { get; set; }

        public int OverAllRating { get; set; }

        public string FeedBack { get; set; }
        [DataType(DataType.Date)]
        public DateOnly RatingDate { get; set; }






    }
}
