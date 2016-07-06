using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TitiShop.Model.Abstract;

namespace TitiShop.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        public string Content { set; get; }

        [Column(TypeName ="varchar")]
        [Required]
        [MaxLength(250)]
        public string Alias { set; get; }
    }
}