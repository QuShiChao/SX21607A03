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
    public class OrderBll
    {
        static Opetate<OrderInfo> orderDal = null;
        static OrderBll()
        {
            if (orderDal == null)
            {
                orderDal = FactoryHelper<OrderInfo>.createFactory().createDal("order");
            }
        }
        //订单添加
        public static int Add(OrderInfo t)
        {
            return orderDal.Add(t);
        }
        //订单删除
        public static int Del(int id)
        {
            return orderDal.Del(id);
        }
        //订单查询
        public static List<OrderInfo> Get()
        {
            return orderDal.Get();
        }
        //订单修改
        public static int Upd(OrderInfo t)
        {
            return orderDal.Upd(t);
        }
    }
}
