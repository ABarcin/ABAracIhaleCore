using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class IletisimTur
    {
        public IletisimTur()
        {
            CalisanIletisims = new HashSet<CalisanIletisim>();
            FirmaIletisims = new HashSet<FirmaIletisim>();
            KullaniciIletisims = new HashSet<KullaniciIletisim>();
        }

        public int IletisimTuruId { get; set; }
        public string Ad { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<CalisanIletisim> CalisanIletisims { get; set; }
        public virtual ICollection<FirmaIletisim> FirmaIletisims { get; set; }
        public virtual ICollection<KullaniciIletisim> KullaniciIletisims { get; set; }
    }
}
