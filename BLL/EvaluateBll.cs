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
    public class EvaluateBll
    {
        static Opetate<EvaluateInfo> evaluateDal = null;
        static EvaluateBll()
        {
            if (evaluateDal == null)
            {
                evaluateDal = FactoryHelper<EvaluateInfo>.createFactory().createDal("evaluate");
            }
        }
        //评价
        public static int Add(EvaluateInfo t)
        {
            return evaluateDal.Add(t);
        }
        //删除评价
        public static int Del(int id)
        {
            return evaluateDal.Del(id);
        }
        //获取评价信息
        public static List<EvaluateInfo> Get()
        {
            return evaluateDal.Get();
        }
        //修改评价信息
        public static int Upd(EvaluateInfo t)
        {
            throw new NotImplementedException();
        }
    }
}
