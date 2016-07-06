using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TitiShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        
        public int ProductID { set; get; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string TagID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}