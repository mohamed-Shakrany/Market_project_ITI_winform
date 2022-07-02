using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagmentSystem2.DAL.Models
{
    public class Product
    {
        #region properties
        [Key]
        public int ProductID { get; set; }
        [Display(Name ="اسم المنتج")]
        public string ProductName { get; set; }
        [Display(Name = "سعر الوحدة")]
        [Column(TypeName ="money")]
        public decimal ProductPrice { get; set; }
        [Display(Name = "الكمية المتاحة")]
        public int Quantity { get; set; }

        #endregion
        #region relation
        [ForeignKey("Category")]
        public int? categoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public ICollection<BuyProcessProduct> buyProcessProducts { get; set; }
        #endregion
    }
}
