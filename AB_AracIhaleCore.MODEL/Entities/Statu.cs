using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Statu
    {
        public Statu()
        {
            AracStatus = new HashSet<AracStatu>();
        }

        public int StatuId { get; set; }
        public string StatuAd { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<AracStatu> AracStatus { get; set; }
    }
}
