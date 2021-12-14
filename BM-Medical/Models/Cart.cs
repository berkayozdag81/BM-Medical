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
        public string MusteriId { get; set; }
        [ForeignKey("MusteriId")]
        public User User { get; set; }
        public int? UrunId { get; set; }
        [ForeignKey("UrunId")]
        public Product Urun { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        [NotMapped] // NotMapped dendiği için db de oluşturulmayacak.
        public double ToplamFiyat
        {
            get
            {
                return Miktar * Fiyat;
            }
        }
    }
}
