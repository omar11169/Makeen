using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventom.Models
{
    public class Committees
    {

        [Key]
        public int CommitteeId { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int RequiredVolunteers { get; set; }

        public string RequiredSkills { get; set; }
        [ForeignKey("Volinteers")]
        public int LeaderId { get; set; }



    }
}
