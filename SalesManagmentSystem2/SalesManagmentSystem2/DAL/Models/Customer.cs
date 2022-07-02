using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagmentSystem2.DAL.Models
{
    public class Customer
    {
        #region properties 
        [Key]
        public int CustID { get; set; }
        [Display(Name = "اسم العميل")]
        public string CustName { get; set; }
        [Display(Name = "عنوان العميل")]
        public string CustAddress { get; set; }
        [Display(Name = "تليفون العميل")]
        public string CustPhone { get; set; }
        [Index("index_customer_mail",IsUnique =true)]
        [Display(Name = "البريد الالكترونى")]
        [MaxLength(255)]
        public string CustMail { get; set; }

        #endregion
        #region relation
        public ICollection<Order> Orders { get; set; }
        #endregion
    }
}
