using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("Category")]
   public  class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName ="varchar")]
        [StringLength(250)]
        public string Name { get; set; }
    }
}
