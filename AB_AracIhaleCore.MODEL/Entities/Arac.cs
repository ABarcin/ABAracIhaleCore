using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Arac
    {
        public Arac()
        {
            AracFiyats = new HashSet<AracFiyat>();
            AracOzelliks = new HashSet<AracOzellik>();
            AracStatus = new HashSet<AracStatu>();
            AracTramers = new HashSet<AracTramer>();
            Fotografs = new HashSet<Fotograf>();
            IhaleAracs = new HashSet<IhaleArac>();
            Ilans = new HashSet<Ilan>();
        }

        public int AracId { get; set; }
        public int KullaniciId { get; set; }
        public int MarkaId { get; set; }
        public int ModelId { get; set; }
        public int Km { get; set; }
        public int Yil { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual ArabaModel Model { get; set; }
        public virtual ICollection<AracFiyat> AracFiyats { get; set; }
        public virtual ICollection<AracOzellik> AracOzelliks { get; set; }
        public virtual ICollection<AracStatu> AracStatus { get; set; }
        public virtual ICollection<AracTramer> AracTramers { get; set; }
        public virtual ICollection<Fotograf> Fotografs { get; set; }
        public virtual ICollection<IhaleArac> IhaleAracs { get; set; }
        public virtual ICollection<Ilan> Ilans { get; set; }
    }
}
