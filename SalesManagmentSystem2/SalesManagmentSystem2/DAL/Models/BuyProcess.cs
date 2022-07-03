using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagmentSystem2.DAL.Models
{
    public class BuyProcess
    {
        [Key]
        [Display(Name = "رقم الفاتورة")]
        public int ID { get; set; }
        [Display(Name ="اسم المندوب")]
        [Required]
        public string FullName { get; set; }
        [Display(Name = "الرقم القومى")]
        [Column(TypeName = "nchar"),MaxLength(14),MinLength(14)]
        [Required]
        public string NationalID { get; set; }
        [Display(Name ="السعر الكلى")]
        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "تاريخ عمليةالاشراء")]
        public DateTime DataProcess { get; set; }

        #region relation
        [Display(Name = "اسم المورد")]
        [ForeignKey("Supplier")]
        public int? SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        #endregion
        #region relation with user
        [Display(Name = "اسم المستخدم")]
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        #endregion
        #region relation with BuyProcessProduct
        public virtual ICollection<BuyProcessProduct> BuyProcessProducts { get; set; }
        #endregion

    }
}
