using AB_AracIhaleCore.DAL.DAL.Abstract;
using AB_AracIhaleCore.DAL.EntitiyFramework.Concrete;
using AB_AracIhaleCore.MODEL.Context;
using AB_AracIhaleCore.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AB_AracIhaleCore.DAL.DAL.Concrete
{
    public class IhaleDAL : EfRepositoryBase<Ihale, Slytherin_AracIhaleContext>, IIhaleDAL
    {
        public int InsertIhale(Ihale ihale)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    using (Slytherin_AracIhaleContext context = new Slytherin_AracIhaleContext())
                    {
                        var value=this.Add(ihale);
                        if (value>0)
                        {
                            int LastID = this.GetAll().OrderByDescending(x => x.IhaleId).FirstOrDefault().IhaleId;
                            ihale.IhaleId = LastID;
                            context.IhaleSurecs.Add(new IhaleSurec()
                            {
                                IhaleId = LastID,
                                StatuIhaleId = 1,
                                Tarih = DateTime.Now
                            });
                            transaction.Complete();
                            return value;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                catch (Exception)
                {
                    //todo şartları koy
                    return 0;
                }
            }
        }

    }
}
