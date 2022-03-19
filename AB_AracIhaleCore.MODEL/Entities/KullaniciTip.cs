using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class KullaniciTip
    {
        public KullaniciTip()
        {
            Ihales = new HashSet<Ihale>();
            Kullanicis = new HashSet<Kullanici>();
        }

        public int KullaniciTipId { get; set; }
        public string Tip { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Ihale> Ihales { get; set; }
        public virtual ICollection<Kullanici> Kullanicis { get; set; }
    }
}
