using AB_AracIhaleCore.DAL.EntitiyFramework.Abstract;
using AB_AracIhaleCore.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB_AracIhaleCore.DAL.DAL.Abstract
{
    public interface IAracTramerDetayDAL : IRepository<AracTramerDetay>
    {
        List<AracTramerDetay> AracTramerDetayGetir(int aracTramerID);
    }
}
