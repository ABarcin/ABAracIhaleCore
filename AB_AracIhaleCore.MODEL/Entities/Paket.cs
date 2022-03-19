using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Paket
    {
        public Paket()
        {
            Firmas = new HashSet<Firma>();
        }

        public int PaketId { get; set; }
        public string Ad { get; set; }
        public int AracLimiti { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Firma> Firmas { get; set; }
    }
}
