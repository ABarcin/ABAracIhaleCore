using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class KullaniciIletisim
    {
        public int KullaniciIletisimId { get; set; }
        public int IletisimTuruId { get; set; }
        public int KullaniciId { get; set; }
        public string IletisimBilgi { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual IletisimTur IletisimTuru { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
