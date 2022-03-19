using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class IhaleStatu
    {
        public IhaleStatu()
        {
            IhaleSurecs = new HashSet<IhaleSurec>();
        }

        public int IhaleStatuId { get; set; }
        public string Durum { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<IhaleSurec> IhaleSurecs { get; set; }
    }
}
