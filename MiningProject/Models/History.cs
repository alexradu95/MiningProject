using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiningProject.Models
{
    [Table("History")]
    public class History
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [ForeignKey("Location")]
        public long LocationID { get; set; }
        public Location Location { get; set; }
        [ForeignKey("Truck")]
        public long TruckID { get; set; }
        public Truck Truck { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}
