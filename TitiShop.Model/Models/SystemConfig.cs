using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TitiShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]        
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string Code { set; get; }

        [MaxLength(250)]
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }
    }
}