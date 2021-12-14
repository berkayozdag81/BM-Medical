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
        public string MusteriId { get; set; }
        [ForeignKey("MusteriId")]
        public User User { get; set; }
        public double ToplamUcret { get; set; }
        public double? KargoUcreti { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public OdemeDurum OdemeDurum { get; set; }
        public string Aciklama { get; set; }
    }
    public enum OdemeDurum
    {
        KrediKarti,
        Havale,
        EFT,
        Kapidaodeme,
    }
}
