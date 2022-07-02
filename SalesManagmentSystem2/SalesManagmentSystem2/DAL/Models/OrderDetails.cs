using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagmentSystem2.DAL.Models
{
    public class OrderDetails
    {
        #region properies
        [Key]
        [Column(Order = 0)]
        public int OrdID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int ProdID { get; set; }
        [Display(Name ="كمية المنتج")]
        public int QuantityProduct { get; set; }
        [Column(TypeName = "money")]
        [Display(Name = "سعر الوحدة")]
        public decimal PriceProduct { get; set; }
        [Column(TypeName = "money")]
        [Display(Name = "اجمالى السعر")]
        public decimal TotalPrice { get; set; }


        #endregion
        #region realtion
        [ForeignKey("Order")]
        public int? orderId { get; set; }
        public Order Order { get; set; }
        [ForeignKey("Product")]
        public int? productId { get; set; }
        public Product Product { get; set; }
        #endregion
    }
}
