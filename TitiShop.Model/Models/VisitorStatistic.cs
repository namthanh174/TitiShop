using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitiShop.Model.Models
{
    [Table("VisitorSatistics")]
    public class VisitorStatistic
    {
        [Key]        
        public int ID { set; get; }

        
        public DateTime VisitedDate { set; get; }

        [Required]
        [MaxLength(50)]
        public string IPAddress { set; get; }
    }
}
