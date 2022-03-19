using AB_AracIhaleCore.DAL.DAL.Abstract;
using AB_AracIhaleCore.DAL.EntitiyFramework.Concrete;
using AB_AracIhaleCore.MODEL.Context;
using AB_AracIhaleCore.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB_AracIhaleCore.DAL.DAL.Concrete
{
    public class AracTramerDetayDAL : EfRepositoryBase<AracTramerDetay, Slytherin_AracIhaleContext>, IAracTramerDetayDAL
    {
        public List<AracTramerDetay> AracTramerDetayGetir(int aracTramerID)
        {
            return GetAll(x => x.AracTramerId == aracTramerID).ToList();
        }
    }
}
