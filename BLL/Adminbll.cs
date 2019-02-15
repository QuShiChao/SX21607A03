using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Factory;
using DataServer;

namespace BLL
{
    public class Adminbll
    {
        static Opetate<AdministratorInfo> adminDal = null;
        static Adminbll()
        {
            if (adminDal == null)
            {
                adminDal= FactoryHelper<AdministratorInfo>.createFactory().createDal("admin");
            }
        }
        //注册
        public static int Add(AdministratorInfo t)
        {
            return adminDal.Add(t);
        }
        //删除
        public static int Del(int id)
        {
            return adminDal.Del(id);
        }
        //获取
        public static List<AdministratorInfo> Get()
        {
            return adminDal.Get();
        }
        //修改
        public static int Upd(AdministratorInfo t)
        {
            throw new NotImplementedException();
        }
    }
}
