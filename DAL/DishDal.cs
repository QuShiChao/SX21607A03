using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataServer;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace DAL
{
    //菜色操作
    public class DishDal : Opetate<DishInfo>
    {
        //菜色添加
        public int Add(DishInfo dish)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                db.Dish.Add(dish);
                return db.SaveChanges();
            }
        }
        //菜色查看
        public List<DishInfo> Get()
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                return db.Dish.Include("Cata").ToList();
            }
        }
        ////菜色删除
        public int Del(int id)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                DishInfo dish = db.Dish.FirstOrDefault(d => d.Id.Equals(id));
                if (dish.Status == 3)
                {
                    dish.Status = 0;
                }
                else
                {
                    dish.Status = 3;
                }
                return db.SaveChanges();
            }
        }
        //菜色修改
        public int Upd(DishInfo dish)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                db.Entry(dish).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
    }
}
