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
        public int ID { get; set; }
        [Display(Name ="اسم المندوب")]
        public string FullName { get; set; }
        [Display(Name = "الرقم القومى")]
        [Column(TypeName = "nchar"),MaxLength(14),MinLength(14)]
        public string NationalID { get; set; }
        [Display(Name ="السعر الكلى")]
        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }
        #region relation
        [ForeignKey("Supplier")]
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        #endregion
        #region relation with user
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { get; set; }
        #endregion
        #region relation with BuyProcessProduct
        public ICollection<BuyProcessProduct> BuyProcessProducts { get; set; }
        #endregion

    }
}
