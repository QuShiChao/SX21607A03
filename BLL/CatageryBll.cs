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
    public class CatageryBll
    {
        static Opetate<Catagery> cataDal = null;
        static CatageryBll()
        {
            if (cataDal == null)
            {
                cataDal = FactoryHelper<Catagery>.createFactory().createDal("cata");
            }
        }
        //菜系添加
        public static int Add(Catagery catagery)
        {
            return cataDal.Add(catagery);
        }
        //菜系删除
        public static int Del(int id)
        {
            throw new NotImplementedException();
        }
        //菜系查看
        public static List<Catagery> Get()
        {
            return cataDal.Get();
        }
        //菜系修改
        public static int Upd(Catagery catagery)
        {
            return cataDal.Upd(catagery);
        }
    }
}
