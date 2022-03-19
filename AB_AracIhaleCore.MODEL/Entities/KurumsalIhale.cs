using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class KurumsalIhale
    {
        public int KurumsalIhaleId { get; set; }
        public int IhaleId { get; set; }
        public int FirmaId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Ihale Ihale { get; set; }
    }
}
