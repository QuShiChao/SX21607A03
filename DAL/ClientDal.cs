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
    public class ClientDal:Opetate<ClientInfo>
    {
        //注册
        public int Add(ClientInfo client)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                db.Client.Add(client);
                return db.SaveChanges();
            }
        }
        //获取用户信息
        public List<ClientInfo> Get()
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                return db.Client.Include("P").ToList();
            }
        }
        //删除
        public int Del(int id)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                ClientInfo client = db.Client.FirstOrDefault(c => c.Id.Equals(id));
                db.Client.Remove(client);
                return db.SaveChanges();
            }
        }
        //修改
        public int Upd(ClientInfo client)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                db.Entry(client).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }
    }
}
