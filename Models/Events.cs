using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Eventom.Models
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }
        [ForeignKey("User")]
        public int CreatorId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }
        
        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public string Location { get; set; }

        public DateOnly RegestrationDeadLine { get; set; }

        public string Status { get; set; }

        public DateOnly CreateDate { get; set; }

        public DateOnly UpdateDate { get; set; }



    }
}
