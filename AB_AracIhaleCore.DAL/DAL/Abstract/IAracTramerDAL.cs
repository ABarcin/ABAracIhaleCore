using AB_AracIhaleCore.DAL.EntitiyFramework.Abstract;
using AB_AracIhaleCore.MODEL.Entities;

namespace AB_AracIhaleCore.DAL.Abstract
{
    public interface IAracTramerDAL : IRepository<AracTramer>
    {
        int AracTramerGetir(int aracID);
    }
}
