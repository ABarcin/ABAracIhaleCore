using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class FavoriOzellik
    {
        public int FavoriOzellikId { get; set; }
        public int OzellikBilgiId { get; set; }
        public int FavoriAramaKriterId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual FavoriAramaKriter FavoriAramaKriter { get; set; }
        public virtual OzellikBilgi OzellikBilgi { get; set; }
    }
}
