using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagmentSystem2.DAL.Models
{
    public  class User
    {
        public enum Geneder
        {
            Male,
            Female
        }
        #region propteries
        [Key]
        public int UserID { get; set; }
        [Display(Name ="اسم المستخدم")]
        public string UserName { get; set; }
        [Display(Name = "عنوان المستخدم")]
        public string UserAddress { get; set; }
        [Display(Name = "رقم التليفون")]
        public string UserPhone { get; set; }
        [Display(Name = "البريد الالكترونى")]
        [MaxLength(255)]
        [Index("index_customer_mail", IsUnique = true)]
        public string UserEmail { get; set; }
        [Display(Name = "النوع")]
        public Geneder UserGeneder { get; set; }
        [Display(Name = "صلاحية المستخدم")]
        [Range(0,1)]
        public byte UserLevel { get; set; }
        [MinLength(8)]
        public string userPassword { get; set; }
        #endregion
        #region relation
        public ICollection<BuyProcess> BuyProcesses { get; set; }
        public ICollection<Order> Orders { get; set; }
        #endregion
    }
}
