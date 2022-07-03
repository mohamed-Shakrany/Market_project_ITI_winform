using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagmentSystem2.DAL.Models
{
    public class Order
    {
        #region properties
        [Key]
        [Display(Name ="رقم الطلب")]
        public int OrderID { get; set; }
        [Display(Name = "تاريخ الطلب")]
        [Required]
        public DateTime OrderDate { get; set; }
        [Display(Name = "اجمالى السعر")]
        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }
        #endregion


        #region realtion
        [Display(Name = "اسم المستخدم")]
        [ForeignKey("User")]
        public int? userId { get; set; }
        public User User { get; set; }
        [ForeignKey("Customer")]
        [Display(Name = "اسم العميل")]
        public int? customerId { get; set; }
        public virtual Customer Customer { get; set; }  

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        #endregion
    }
}
