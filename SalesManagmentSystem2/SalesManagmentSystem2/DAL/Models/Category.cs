using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Index("index_category_name", IsUnique = true)]
        [MaxLength(255)]
        [Required]
        public string CatName { get; set; }
        public string CatImg { get; set; }
        #endregion
        #region  relation
        public virtual ICollection<Product> Products { get; set; }  
        #endregion
    }
}
