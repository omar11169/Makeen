using System.ComponentModel.DataAnnotations.Schema;

namespace Eventom.Models
{
    public class Volunteers : User
    {
        [ForeignKey("User")]
        public int VolunteerId { get; set; }

        public int EducationLevel { get; set; }

        public string FieldOfStudy { get; set; }

        public string  Skills { get; set; }

        public string Interests { get; set; }

        public string PreviousExperience { get; set; }

        public int TotalEventParticipated { get; set; }

        public int AverageRating { get; set; }

        public int VolunteerLevel { get; set; }



    }
}
