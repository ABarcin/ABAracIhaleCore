using AB_AracIhaleCore.DAL.Abstract;
using AB_AracIhaleCore.DAL.EntitiyFramework.Concrete;
using AB_AracIhaleCore.MODEL.Context;
using AB_AracIhaleCore.MODEL.Entities;
using System.Linq;

namespace AB_AracIhaleCore.DAL.Concrete
{
    public class AracTramerDAL : EfRepositoryBase<AracTramer, Slytherin_AracIhaleContext>, IAracTramerDAL
    {
        public int AracTramerGetir(int aracID)
        {

            return this.GetAll(x => x.AracId == aracID).OrderByDescending(y => y.AracTramerId).FirstOrDefault().AracTramerId;
        }
    }
}