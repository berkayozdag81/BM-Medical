using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BM_Medical.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string FotoAd { get; set; }
    }
}
