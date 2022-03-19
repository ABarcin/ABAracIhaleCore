using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class AracTeklif
    {
        public int AracTeklifId { get; set; }
        public int IhaleAracId { get; set; }
        public int KullaniciId { get; set; }
        public decimal TeklifFiyat { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? TeklifOnay { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual IhaleArac IhaleArac { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
