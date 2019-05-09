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
        [ForeignKey("LocationID")]
        public Location Location { get; set; }
        [ForeignKey("TruckID")]
        public Truck Truck { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
