using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class AracStatu
    {
        public int AracStatuId { get; set; }
        public int AracId { get; set; }
        public int StatuId { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual Statu Statu { get; set; }
    }
}
