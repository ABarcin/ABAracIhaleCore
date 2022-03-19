using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Firma
    {
        public Firma()
        {
            FirmaIletisims = new HashSet<FirmaIletisim>();
            KurumsalKullanicis = new HashSet<KurumsalKullanici>();
            Stoks = new HashSet<Stok>();
        }

        public int FirmaId { get; set; }
        public string Unvan { get; set; }
        public int? SehirIlceId { get; set; }
        public int? FirmaTipId { get; set; }
        public int? PaketId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual FirmaTip FirmaTip { get; set; }
        public virtual Paket Paket { get; set; }
        public virtual SehirIlce SehirIlce { get; set; }
        public virtual ICollection<FirmaIletisim> FirmaIletisims { get; set; }
        public virtual ICollection<KurumsalKullanici> KurumsalKullanicis { get; set; }
        public virtual ICollection<Stok> Stoks { get; set; }
    }
}
