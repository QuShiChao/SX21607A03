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
    public class DishBll
    {
        static Opetate<DishInfo> dishDal = null;
        static DishBll()
        {
            if (dishDal == null)
            {
                dishDal = FactoryHelper<DishInfo>.createFactory().createDal("dish");
            }
        }
        //菜色添加
        public static int Add(DishInfo dish)
        {
            return dishDal.Add(dish);
        }
        //菜色查看
        public static List<DishInfo> Get()
        {
            return dishDal.Get();
        }
        //菜色删除
        public static int Del(int id)
        {
            return dishDal.Del(id);
        }
        //菜色修改
        public static int Upd(DishInfo dish)
        {
            return dishDal.Upd(dish);
        }
    }
}
