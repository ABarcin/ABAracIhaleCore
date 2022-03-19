using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB_AracIhaleCore.DAL.Enums
{
    public enum TramerEnum
    {
        [Display(Name = "Orijinal")]
        Orijinal = 1,
        [Display(Name = "Boyalı")]
        Boyali,
        [Display(Name = "Değişmiş")]
        Degismis
    }
}
