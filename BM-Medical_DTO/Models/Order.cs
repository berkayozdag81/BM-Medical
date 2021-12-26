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
        public string UserName { get; set; }
        public double ToplamUcret { get; set; }
        public DateTime SiparisTarihi { get; set; }
    }
}
