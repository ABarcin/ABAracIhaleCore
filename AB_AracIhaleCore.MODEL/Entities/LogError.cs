using System;
using System.Collections.Generic;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Entities
{
    public partial class LogError
    {
        public int LogErrorId { get; set; }
        public DateTime LogTarih { get; set; }
        public string Kullanici { get; set; }
        public string Sayfa { get; set; }
        public string LogMesaj { get; set; }
        public string Islem { get; set; }
        public string Hata { get; set; }
    }
}
