using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class FavoriAramaKriter
    {
        public FavoriAramaKriter()
        {
            FavoriAramas = new HashSet<FavoriArama>();
            FavoriOzelliks = new HashSet<FavoriOzellik>();
        }

        public int FavoriAramaKriterId { get; set; }
        public int? MarkaId { get; set; }
        public int? ModelId { get; set; }
        public DateTime? BaslangicYil { get; set; }
        public DateTime? BitisYil { get; set; }
        public decimal? BaslangicFiyat { get; set; }
        public decimal? BitisFiyat { get; set; }
        public int? BaslangicKm { get; set; }
        public int? BitisKm { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Marka Marka { get; set; }
        public virtual ArabaModel Model { get; set; }
        public virtual ICollection<FavoriArama> FavoriAramas { get; set; }
        public virtual ICollection<FavoriOzellik> FavoriOzelliks { get; set; }
    }
}
