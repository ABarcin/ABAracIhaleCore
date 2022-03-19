using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AB_AracIhaleCore.UI.Models.ApiModels
{
    public class MyAracTramer
    {
        public int AracTramerID { get; set; }
        public int AracID { get; set; }
        public decimal Fiyat { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
