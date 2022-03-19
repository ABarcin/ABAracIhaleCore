using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class AracTramer
    {
        public AracTramer()
        {
            AracTramerDetays = new HashSet<AracTramerDetay>();
        }

        public int AracTramerId { get; set; }
        public int AracId { get; set; }
        public decimal Fiyat { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual ICollection<AracTramerDetay> AracTramerDetays { get; set; }
    }
}
