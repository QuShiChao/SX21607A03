using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Factory;
using DataServer;

namespace BLL
{
    public class ClientBll
    {
        static Opetate<ClientInfo> clientDal = null;
        static ClientBll()
        {
            if (clientDal == null)
            {
                clientDal = FactoryHelper<ClientInfo>.createFactory().createDal("client");
            }
        }
        //注册
        public static int Add(ClientInfo client)
        {
            return clientDal.Add(client);
        }
        //获取用户信息
        public static List<ClientInfo> Get()
        {
            return clientDal.Get();
        }
        //删除
        public static int Del(int id)
        {
            return clientDal.Del(id);
        }
        //修改
        public static int Upd(ClientInfo client)
        {
            return clientDal.Upd(client);
        }
    }
}
