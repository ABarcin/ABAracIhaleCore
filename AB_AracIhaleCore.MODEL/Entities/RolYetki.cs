using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class RolYetki
    {
        public int RolYetkiId { get; set; }
        public int RolId { get; set; }
        public int YetkiId { get; set; }
        public int SayfaId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual Sayfa Sayfa { get; set; }
        public virtual Yetki Yetki { get; set; }
    }
}
