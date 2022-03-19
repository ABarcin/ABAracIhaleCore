using AB_AracIhaleCore.DAL.EntitiyFramework.Abstract;
using AB_AracIhaleCore.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB_AracIhaleCore.DAL.DAL.Abstract
{
    public interface IKullaniciDAL : IRepository<Kullanici>
    {
        Kullanici Register(Kullanici kullanici, string password);
        Kullanici Login(string username, string password);
        bool UserExist(string username);
        bool OturumAc(string kullaniciAdi, string sifre);
    }
}
