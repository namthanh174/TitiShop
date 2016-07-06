using System.ComponentModel.DataAnnotations.Schema;

namespace TitiShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public int OrderID { set; get; }

        public int ProductID { set; get; }
        public int Quantity { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
    }
}