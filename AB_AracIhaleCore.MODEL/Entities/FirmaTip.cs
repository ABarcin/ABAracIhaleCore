using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class FirmaTip
    {
        public FirmaTip()
        {
            Firmas = new HashSet<Firma>();
        }

        public int FirmaTipId { get; set; }
        public string FirmaTur { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Firma> Firmas { get; set; }
    }
}
