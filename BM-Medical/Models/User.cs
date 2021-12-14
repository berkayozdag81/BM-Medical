using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BM_Medical.Models
{
    public class User:IdentityUser
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        [NotMapped]
        public string AdSoyad
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }
    }
}
