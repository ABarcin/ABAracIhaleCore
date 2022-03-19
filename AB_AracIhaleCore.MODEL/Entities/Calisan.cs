using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Calisan
    {
        public Calisan()
        {
            CalisanIletisims = new HashSet<CalisanIletisim>();
            Ihales = new HashSet<Ihale>();
        }

        public int CalisanId { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public int RolId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool? AktiflikDurumu { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual ICollection<CalisanIletisim> CalisanIletisims { get; set; }
        public virtual ICollection<Ihale> Ihales { get; set; }
    }
}
