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
    public class EvaluateDal : Opetate<EvaluateInfo>
    {
        OrderDbContext db = new OrderDbContext();
        //dbContext.Configuration.ValidateOnSaveEnabled = false
        //评价
        public int Add(EvaluateInfo t)
        {
            
            db.Evaluate.Add(t);
            return db.SaveChanges();
        }
        //删除评价
        public int Del(int id)
        {
            EvaluateInfo evaluate = db.Evaluate.FirstOrDefault(e => e.Id.Equals(id));
            db.Evaluate.Remove(evaluate);
            return db.SaveChanges();
        }
        //获取评价信息
        public List<EvaluateInfo> Get()
        {
            return db.Evaluate.Include("Client").Include("Dish").ToList();
        }
        //修改评价信息
        public int Upd(EvaluateInfo t)
        {
            throw new NotImplementedException();
        }
    }
}
