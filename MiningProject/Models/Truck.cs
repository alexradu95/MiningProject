using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiningProject.Models
{
    [Table("Trucks")]
    public class Truck
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string PlateNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string TruckType { get; set; }
    }
}
