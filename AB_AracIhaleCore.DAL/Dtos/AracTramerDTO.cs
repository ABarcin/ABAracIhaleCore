using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB_AracIhaleCore.DAL.Dtos
{
    public class AracTramerDTO 
    {
        public int AracTramerID { get; set; }
        public int AracID { get; set; }
        public decimal Fiyat { get; set; }

    }
}
