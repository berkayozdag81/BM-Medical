using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM_Medical.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string ÜrünAdi { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
        public int Stok { get; set; }
        public List<Image> Images { get; set; }
    }
}
