using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class OzellikBilgi
    {
        public OzellikBilgi()
        {
            AracOzelliks = new HashSet<AracOzellik>();
            FavoriOzelliks = new HashSet<FavoriOzellik>();
        }

        public int OzellikBilgiId { get; set; }
        public string OzellikDetay { get; set; }
        public int OzellikId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Ozellik Ozellik { get; set; }
        public virtual ICollection<AracOzellik> AracOzelliks { get; set; }
        public virtual ICollection<FavoriOzellik> FavoriOzelliks { get; set; }
    }
}
