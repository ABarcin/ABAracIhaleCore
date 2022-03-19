using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class ArabaModel
    {
        public ArabaModel()
        {
            Aracs = new HashSet<Arac>();
            FavoriAramaKriters = new HashSet<FavoriAramaKriter>();
        }

        public int ModelId { get; set; }
        public int MarkaId { get; set; }
        public string Ad { get; set; }
        public int UstModelId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Arac> Aracs { get; set; }
        public virtual ICollection<FavoriAramaKriter> FavoriAramaKriters { get; set; }
    }
}
