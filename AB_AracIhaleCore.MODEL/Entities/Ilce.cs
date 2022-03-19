using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Ilce
    {
        public Ilce()
        {
            SehirIlces = new HashSet<SehirIlce>();
        }

        public int IlceId { get; set; }
        public string Ad { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<SehirIlce> SehirIlces { get; set; }
    }
}
