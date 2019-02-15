using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer
{
    //操作接口
    public interface Opetate<T>
    {
        int Add(T t);
        List<T> Get();
        int Del(int id);
        int Upd(T t);
    }
}
