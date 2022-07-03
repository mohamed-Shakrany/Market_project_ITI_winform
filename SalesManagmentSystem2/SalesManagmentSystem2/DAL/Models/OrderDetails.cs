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
        [Required]
        [ForeignKey("Order")]
        [Display(Name = "رقم الطلب")]
        public int Id_o { get; set; }
        [Key]
        [Column(Order = 1)]
        [Display(Name = "اسم المنتج")]
        [Required]
        [ForeignKey("Product")]
        public int  Id_pp { get; set; }
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
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        #endregion
    }
}
