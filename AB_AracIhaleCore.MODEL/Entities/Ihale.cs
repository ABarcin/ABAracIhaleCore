using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Ihale
    {
        public Ihale()
        {
            IhaleAracs = new HashSet<IhaleArac>();
            IhaleSurecs = new HashSet<IhaleSurec>();
            KurumsalIhales = new HashSet<KurumsalIhale>();
        }

        public int IhaleId { get; set; }
        public string IhaleAdi { get; set; }
        public int CalisanId { get; set; }
        public int KullaniciTipId { get; set; }
        public DateTime IhaleBaslangic { get; set; }
        public DateTime IhaleBitis { get; set; }
        public TimeSpan BaslangicSaat { get; set; }
        public TimeSpan BitisSaat { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Calisan Calisan { get; set; }
        public virtual KullaniciTip KullaniciTip { get; set; }
        public virtual ICollection<IhaleArac> IhaleAracs { get; set; }
        public virtual ICollection<IhaleSurec> IhaleSurecs { get; set; }
        public virtual ICollection<KurumsalIhale> KurumsalIhales { get; set; }
    }
}
