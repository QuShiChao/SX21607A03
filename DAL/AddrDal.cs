using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataServer;

namespace DAL
{
    public class AddrDal : Opetate<AddressInfo>
    {
        OrderDbContext db = new OrderDbContext();
        //地址添加
        public int Add(AddressInfo t)
        {
            throw new NotImplementedException();
        }
        //地址删除
        public int Del(int id)
        {
            throw new NotImplementedException();
        }
        //地址获取
        public List<AddressInfo> Get()
        {
            List<AddressInfo> addrs = db.Address.ToList();
            if (addrs.Count <= 0)
            {
                List<AddressInfo> addresses = new List<AddressInfo>() {
                new AddressInfo{Id=1,Name="河南省",Pid=0 },
                new AddressInfo{Id=2,Name="河北省",Pid=0 },
                new AddressInfo{Id=3,Name="北京市",Pid=0 },
                new AddressInfo{Id=4,Name="上海市",Pid=0 },
                new AddressInfo{Id=5,Name="郑州市",Pid=1 },
                new AddressInfo{Id=6,Name="平顶山市",Pid=1 },
                new AddressInfo{Id=7,Name="石家庄市",Pid=2 },
                new AddressInfo{Id=8,Name="邯郸市",Pid=2 },
                new AddressInfo{Id=9,Name="海淀区",Pid=3 },
                new AddressInfo{Id=10,Name="房山区",Pid=3 },
                new AddressInfo{Id=11,Name="浦东新区",Pid=4 },
                new AddressInfo{Id=12,Name="闵行区",Pid=4 },
                new AddressInfo{Id=13,Name="金水区",Pid=5 },
                new AddressInfo{Id=14,Name="叶县",Pid=6 },
                new AddressInfo{Id=15,Name="石家庄一区",Pid=7 },
                new AddressInfo{Id=16,Name="邯郸一区",Pid=8 }
            };
                foreach (var item in addresses)
                {
                    db.Address.Add(item);
                }
                db.SaveChanges();
            }
            return db.Address.ToList();
        }
        //地址修改
        public int Upd(AddressInfo t)
        {
            throw new NotImplementedException();
        }
    }
}
