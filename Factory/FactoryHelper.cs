using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DataServer;
using System.Reflection;
using System.Configuration;

namespace Factory
{
    public class FactoryHelper<T>
    {
        public static AbstractFactory<T> createFactory()
        {
            //获取类名称
            string className = ConfigurationManager.AppSettings["fac"];
            //获取程序集
            Assembly assembly = Assembly.GetExecutingAssembly();
            //创建具体工厂-泛型反射
            Type type = assembly.GetType(className);
            Type result = type.MakeGenericType(typeof(T));
            AbstractFactory<T> factory = assembly.CreateInstance(result.FullName) as AbstractFactory<T>;
            return factory;
        }
    }
}
