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
    //菜系操作
    public class CatageryDal:Opetate<Catagery>
    {
        //菜系添加
        public int Add(Catagery catagery)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                db.Catagery.Add(catagery);
                return db.SaveChanges();
            }
        }
        //菜系删除
        public int Del(int id)
        {
            throw new NotImplementedException();
        }
        //菜系查看
        public List<Catagery> Get()
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                return db.Catagery.ToList();
            }
        }
        //菜系修改
        public int Upd(Catagery catagery)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                db.Entry(catagery).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
    }
}
