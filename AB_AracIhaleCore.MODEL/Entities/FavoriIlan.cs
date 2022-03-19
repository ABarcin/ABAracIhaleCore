using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class FavoriIlan
    {
        public int FavoriIlanId { get; set; }
        public int KullaniciId { get; set; }
        public int IlanId { get; set; }
        public DateTime Tarih { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Ilan Ilan { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
