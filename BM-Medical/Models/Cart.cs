using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BM_Medical.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public CartStatu CartStatu { get; set; }
        public double Miktar { get; set; }
        public double LastFiyat { get; set; } // Ürünün fiiyatında indirim yapıldıktan sonraki soın hali.
    }
}
