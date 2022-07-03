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
        [Required]
        public string ProductName { get; set; }
        [Display(Name = "سعر الوحدة")]
        [Column(TypeName ="money")]
        public decimal ProductPrice { get; set; }
        [Display(Name = "الكمية المتاحة")]
        public int Quantity { get; set; }

        #endregion
        #region relation
        [ForeignKey("Category")]
        [Display(Name = "الصنف")]
        public int? categoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<BuyProcessProduct> buyProcessProducts { get; set; }
        #endregion
    }
}
