using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Yetki
    {
        public Yetki()
        {
            RolYetkis = new HashSet<RolYetki>();
        }

        public int YetkiId { get; set; }
        public string YetkiAciklama { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<RolYetki> RolYetkis { get; set; }
    }
}
