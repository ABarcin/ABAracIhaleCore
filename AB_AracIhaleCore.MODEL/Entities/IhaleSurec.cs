using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class IhaleSurec
    {
        public int StatuIhaleId { get; set; }
        public int IhaleId { get; set; }
        public int IhaleStatuId { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual Ihale Ihale { get; set; }
        public virtual IhaleStatu IhaleStatu { get; set; }
    }
}
