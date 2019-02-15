using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;
using DataServer;

namespace DAL
{
    public class AdminDal:Opetate<AdministratorInfo>
    {
        OrderDbContext db = new OrderDbContext();
        //注册
        public int Add(AdministratorInfo t)
        {
            db.Administrator.Add(t);
            return db.SaveChanges();
        }
        //删除
        public int Del(int id)
        {
            throw new NotImplementedException();
        }
        //获取
        public List<AdministratorInfo> Get()
        {
            return db.Administrator.ToList();
        }
        //修改
        public int Upd(AdministratorInfo t)
        {
            throw new NotImplementedException();
        }
    }
}
