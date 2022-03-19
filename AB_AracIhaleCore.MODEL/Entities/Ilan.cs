using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Ilan
    {
        public Ilan()
        {
            FavoriIlans = new HashSet<FavoriIlan>();
        }

        public int IlanId { get; set; }
        public int AracId { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual ICollection<FavoriIlan> FavoriIlans { get; set; }
    }
}
