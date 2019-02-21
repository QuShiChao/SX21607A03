using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataServer;

namespace DAL
{
    public class logisticsDal : Opetate<logistics>
    {
        //物流信息添加
        public int Add(logistics t)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                db.Logistics.Add(t);
                return db.SaveChanges();
            }
        }
        //物流信息删除
        public int Del(int id)
        {
            throw new NotImplementedException();
        }
        //物流信息查看
        public List<logistics> Get()
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                return db.Logistics.Include("Order").ToList();
            }
        }
        //物流信息修改
        public int Upd(logistics t)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                db.Entry(t).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
        }
    }
}
