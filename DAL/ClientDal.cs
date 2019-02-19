using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

namespace DAL
{
    public class ClientDal
    {
        static OrderDbContext db = new OrderDbContext();
        //注册
        public static int Add(ClientInfo client)
        {
            db.Client.Add(client);
            return db.SaveChanges();
        }
        //获取用户信息
        public static List<ClientInfo> Get()
        {
            return db.Client.Include("P").ToList();
        }
        //删除
        public static int Del(int id)
        {
            ClientInfo client = db.Client.FirstOrDefault(c => c.Id.Equals(id));
            db.Client.Remove(client);
            return db.SaveChanges();
        }
        //修改
        public static int Upd(ClientInfo client)
        {
            db.Entry(client).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
