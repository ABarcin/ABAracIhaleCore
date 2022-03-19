using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class FavoriArama
    {
        public int FavoriAramaId { get; set; }
        public int FavoriAramaKriterId { get; set; }
        public int KullaniciId { get; set; }
        public string Ad { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual FavoriAramaKriter FavoriAramaKriter { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
