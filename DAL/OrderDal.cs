using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataServer;
using Model;

namespace DAL
{
    public class OrderDal : Opetate<OrderInfo>
    {
        
        //订单添加
        public int Add(OrderInfo t)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                db.Order.Add(t);
                return db.SaveChanges();
            }
        }
        //订单删除
        public int Del(int id)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                OrderInfo order = db.Order.FirstOrDefault(o => o.Id.Equals(id));
                db.Order.Remove(order);
                return db.SaveChanges();
            }
        }
        //订单查询
        public List<OrderInfo> Get()
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                return db.Order.ToList();
            }
        }
        //订单修改
        public int Upd(OrderInfo t)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
        }
    }
}
