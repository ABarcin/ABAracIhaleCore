using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AB_AracIhaleCore.DAL.Dtos
{
    public class IhaleDTO
    {
        public int IhaleID { get; set; }

        [Required]
        public string IhaleAdi { get; set; }

        public int CalisanID { get; set; }

        public int KullaniciTipID { get; set; }

        [Column(TypeName = "date")]
        public DateTime IhaleBaslangic { get; set; }

        [Column(TypeName = "date")]
        public DateTime IhaleBitis { get; set; }
        public TimeSpan BaslangicSaat { get; set; }
        public TimeSpan BitisSaat { get; set; }
    }
}
