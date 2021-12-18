using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BM_Medical.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public double ToplamUcret { get; set; }
        public List<Product> Urunler { get; set; }
        public DateTime SiparisTarihi { get; set; }
    }
}
