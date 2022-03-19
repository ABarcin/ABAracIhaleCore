using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Rol
    {
        public Rol()
        {
            Calisans = new HashSet<Calisan>();
            Kullanicis = new HashSet<Kullanici>();
            RolYetkis = new HashSet<RolYetki>();
        }

        public int RolId { get; set; }
        public string Ad { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Calisan> Calisans { get; set; }
        public virtual ICollection<Kullanici> Kullanicis { get; set; }
        public virtual ICollection<RolYetki> RolYetkis { get; set; }
    }
}
