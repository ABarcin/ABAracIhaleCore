using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class AracTramerDetay
    {
        public int AracTramerDetayId { get; set; }
        public int AracParcaId { get; set; }
        public int AracTramerId { get; set; }
        public int TramerDetayId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual AracParca AracParca { get; set; }
        public virtual AracTramer AracTramer { get; set; }
        public virtual TramerDetay TramerDetay { get; set; }
    }
}
