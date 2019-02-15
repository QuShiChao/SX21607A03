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
    public class AddrBll
    {
        static Opetate<AddressInfo> addrDal = null;
        static AddrBll()
        {
            if (addrDal == null)
            {
                addrDal = FactoryHelper<AddressInfo>.createFactory().createDal("addr");
            }
        }
        //地址获取
        public static List<AddressInfo> Get()
        {
            return addrDal.Get();
        }
    }
}
