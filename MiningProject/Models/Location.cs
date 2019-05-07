using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiningProject.Models
{
    [Table("Location")]
    public class Location
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string LocationName { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
