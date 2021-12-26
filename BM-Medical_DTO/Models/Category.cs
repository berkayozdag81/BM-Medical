using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BM_Medical.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Kategori Adı")]
        public string Ad { get; set; }
    }
}
