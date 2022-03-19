using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class SehirIlce
    {
        public SehirIlce()
        {
            Firmas = new HashSet<Firma>();
        }

        public int SehirIlceId { get; set; }
        public int SehirId { get; set; }
        public int IlceId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Ilce Ilce { get; set; }
        public virtual Sehir Sehir { get; set; }
        public virtual ICollection<Firma> Firmas { get; set; }
    }
}
