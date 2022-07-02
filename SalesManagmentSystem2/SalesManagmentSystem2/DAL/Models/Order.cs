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
        public int OrderID { get; set; }
        [Display(Name = "تاريخ الطلب")]
        public DateTime OrderDate { get; set; }
        [Display(Name = "اجمالى السعر")]
        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }
        #endregion


        #region realtion
        [ForeignKey("User")]
        public int? userId { get; set; }
        public User User { get; set; }
        [ForeignKey("Customer")]
        public int? customerId { get; set; }
        public Customer Customer { get; set; }  

        public ICollection<OrderDetails> OrderDetails { get; set; }
        #endregion
    }
}
