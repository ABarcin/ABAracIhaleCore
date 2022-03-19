using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class Ozellik
    {
        public Ozellik()
        {
            OzellikBilgis = new HashSet<OzellikBilgi>();
        }

        public int OzellikId { get; set; }
        public string OzellikAd { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<OzellikBilgi> OzellikBilgis { get; set; }
    }
}
