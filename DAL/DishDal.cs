using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataServer;
using System.Data.Entity;

namespace DAL
{
    //菜色操作
    public class DishDal : Opetate<DishInfo>
    {
        OrderDbContext db = new OrderDbContext();
        //菜色添加
        public int Add(DishInfo dish)
        {
            db.Dish.Add(dish);
            return db.SaveChanges();
        }
        //菜色查看
        public List<DishInfo> Get()
        {
            return db.Dish.Include("Cata").ToList();
        }
        //菜色删除
        public int Del(int id)
        {
            DishInfo dish = db.Dish.FirstOrDefault(d => d.Id.Equals(id));
            db.Dish.Remove(dish);
            return db.SaveChanges();
        }
        //菜色修改
        public int Upd(DishInfo dish)
        {
            db.Entry(dish).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
