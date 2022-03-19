using AB_AracIhaleCore.CORE;
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
    public class KullaniciDAL : EfRepositoryBase<Kullanici, Slytherin_AracIhaleContext>, IKullaniciDAL
    {
        public Kullanici Login(string username, string password)
        {
            if (!this.OturumAc(username, password))
            {
                return null;
            }
            return this.GetAll(x => x.KullaniciAd == username).FirstOrDefault();

        }

        public bool OturumAc(string kullaniciAdi, string sifre)
        {
            bool dogruMu = false;
            Kullanici calisan = GetAll().Where(x => x.KullaniciAd.TrimEnd() == kullaniciAdi && SlytherinCryption.Decrypt(x.Sifre) == sifre).SingleOrDefault();
            if (calisan != null)
            {
                dogruMu = true;
            }
            return dogruMu;
        }

        public Kullanici Register(Kullanici kullanici, string password)
        {
            //TODO Yapılacak
            return null;
        }

        public bool UserExist(string username)
        {
            //TODO Yapılacak
            return false;
        }
    }
}
