using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class IhaleArac
    {
        public IhaleArac()
        {
            AracTeklifs = new HashSet<AracTeklif>();
        }

        public int IhaleAracId { get; set; }
        public int IhaleId { get; set; }
        public int AracId { get; set; }
        public decimal IhaleBaslangicFiyat { get; set; }
        public decimal MinAlimFiyati { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual Ihale Ihale { get; set; }
        public virtual ICollection<AracTeklif> AracTeklifs { get; set; }
    }
}
