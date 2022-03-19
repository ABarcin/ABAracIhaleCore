using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB_AracIhaleCore.DAL.Enums
{
    public enum ParcaEnum
    {
        [Display(Name = "Tavan")]
        Tavan = 1,
        [Display(Name = "Ön Tampon")]
        OnTampon,
        [Display(Name = "Arka Tampon")]
        ArkaTampon,
        [Display(Name = "Motor Kaputu")]
        MotorKaputu,
        [Display(Name = "Arka Kaput")]
        ArkaKaput,
        [Display(Name = "Sağ Ön Kapı")]
        SagOnKapi,
        [Display(Name = "Sağ Ön Çamurluk")]
        SagOnCamurluk,
        [Display(Name = "Sağ Arka Kapı")]
        SagArkaKapi,
        [Display(Name = "Sağ Arka Çamurluk")]
        SagArkaCamurluk,
        [Display(Name = "Sol Ön Kapı")]
        SolOnKapi,
        [Display(Name = "Sol Ön Çamurluk")]
        SolOnCamurluk,
        [Display(Name = "Sol Arka Kapı")]
        SolArkaKapi,
        [Display(Name = "Sol Arka Çamurluk")]
        SolArkaCamurluk
    }
}
