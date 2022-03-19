using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Kullanici
    {
        public Kullanici()
        {
            AracTeklifs = new HashSet<AracTeklif>();
            Aracs = new HashSet<Arac>();
            FavoriAramas = new HashSet<FavoriArama>();
            FavoriIlans = new HashSet<FavoriIlan>();
            KullaniciIletisims = new HashSet<KullaniciIletisim>();
            KurumsalKullanicis = new HashSet<KurumsalKullanici>();
        }

        public int KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public int KullaniciTipId { get; set; }
        public string Sifre { get; set; }
        public int RolId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool? Kvkk { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual KullaniciTip KullaniciTip { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual ICollection<AracTeklif> AracTeklifs { get; set; }
        public virtual ICollection<Arac> Aracs { get; set; }
        public virtual ICollection<FavoriArama> FavoriAramas { get; set; }
        public virtual ICollection<FavoriIlan> FavoriIlans { get; set; }
        public virtual ICollection<KullaniciIletisim> KullaniciIletisims { get; set; }
        public virtual ICollection<KurumsalKullanici> KurumsalKullanicis { get; set; }
    }
}
