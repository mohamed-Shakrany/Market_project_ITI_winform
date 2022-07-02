using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagmentSystem2.DAL.Models
{
    public class Category
    {
        #region properties
        [Key]
        public int CatID { get; set; }
        [Display(Name ="اسم الصنف")]
        public string CatName { get; set; }
        public string CatImg { get; set; }
        #endregion
        #region  relation
        public ICollection<Product> Products { get; set; }  
        #endregion
    }
}
