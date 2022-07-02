using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagmentSystem2.DAL.Models
{
    public class Supplier
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="اسم المورد")]
        public string SuppName { get; set; }
        [Display(Name = "العنوان")]
        public string SuppAddress { get; set; }
        [Display(Name = "رقم التليفون")]

        public string SuppPhone { get; set; }
        [Display(Name = "البريد الالكترونى")]
        [Index("index_customer_mail", IsUnique = true)]
        [MaxLength(255)]
        public string SuppMail { get; set; }

        #region relation
        public  ICollection<BuyProcess> BuyProcesses { get; set; }
        #endregion
    }
}
