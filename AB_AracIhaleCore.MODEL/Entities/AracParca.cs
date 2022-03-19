using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class AracParca
    {
        public AracParca()
        {
            AracTramerDetays = new HashSet<AracTramerDetay>();
        }

        public int AracParcaId { get; set; }
        public string ParcaAd { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<AracTramerDetay> AracTramerDetays { get; set; }
    }
}
