using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagmentSystem2.DAL.Models
{
    public class BuyProcessProduct
    {
        #region properties
        [Key]

        [Column(Order = 0)]
        [ForeignKey("Product")]
        [Display(Name ="اسم المنتج")]
        [Required]
        public int Id_p { get; set; }
        [Key]
        [Column(Order = 1)]
        [Display(Name = "رقم الفاتورة")]
        [ForeignKey("BuyProcess")]
        [Required]

        public int Id_bp { get; set; }
        [Display(Name = "اجمالى كمية المنتج")]
        public int Total_quantity { get; set; }
        [Column(TypeName ="date")]
        [Display(Name = "تاريخ انتاج المنتج")]
        public DateTime ProductDate { get; set; }
        [Column(TypeName = "date")]
        [Display(Name = "تاريخ انتهاء المنتج")]
        public DateTime ExpireDate { get; set; }
        #endregion
        #region relation 
        public virtual BuyProcess BuyProcess { get; set; }
        public virtual Product Product { get; set; }

        #endregion
    }
}
