using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Eventom.Data;

namespace Eventom.Models
{
    public class Applications
    {
        [Key]
        public int ApplicationId { get; set; }

        [ForeignKey("VolunteerId")]
        public int VolunteerId { get; set; }
        [ForeignKey("CommitteeId")]
        public int CommitteeId { get; set; }


        public DateOnly ApplicationDate { get; set; }

        public string Status { get; set; }

        public string MotivationStatment { get; set; }

        public string RelevantExperoence { get; set; }

        public DateOnly DecisionDate { get; set; }

        public string DecisionReason { get; set; }



    }
}
