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
    public class LogisticsBll
    {
        static Opetate<logistics> logisticsDal = null;
        static LogisticsBll()
        {
            if (logisticsDal == null)
            {
                logisticsDal = FactoryHelper<logistics>.createFactory().createDal("logistics");
            }
        }
        //物流信息添加
        public static int Add(logistics logistics)
        {
            return logisticsDal.Add(logistics);
        }
        //菜系删除
        public static int Del(int id)
        {
            throw new NotImplementedException();
        }
        //菜系查看
        public static List<logistics> Get()
        {
            return logisticsDal.Get();
        }
        //菜系修改
        public static int Upd(logistics logistics)
        {
            return logisticsDal.Upd(logistics);
        }
    }
}
