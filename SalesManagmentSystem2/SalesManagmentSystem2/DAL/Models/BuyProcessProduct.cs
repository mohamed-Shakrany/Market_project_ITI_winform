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
        public int prodID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int BuyID { get; set; }
        [Column(TypeName = "date",Order = 2)]
        [Display(Name ="تاريخ عمليةالاشراء")] 
        public DateTime DataProcess { get; set; }
        [Display(Name = "اجمالى الكمية")]
        [Column(TypeName ="decimal")]
        public decimal Total_quantity { get; set; }
        [Column(TypeName ="date")]
        [Display(Name = "تاريخ انتاج المنتج")]
        public DateTime ProductDate { get; set; }
        [Column(TypeName = "date")]
        [Display(Name = "تاريخ انتهاء المنتج")]
        public DateTime ExpireDate { get; set; }

        #endregion

        #region relation 
        [ForeignKey("BuyProcess")]
        public int? BuyProcessId { get; set; }
        public BuyProcess BuyProcess { get; set; }

        [ForeignKey("Product")]
        public int? ProductId { get; set; }
        public Product Product { get; set; }

        #endregion
    }
}
