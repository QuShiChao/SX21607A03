using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataServer;
using DAL;
using System.Reflection;
using System.Configuration;

namespace Factory
{
    //订餐工厂
    public class OrderFactory<T> : AbstractFactory<T>
    {
        public override Opetate<T> createDal(string dalName)
        {
            //获取程序的工作目录
            string curPath = AppDomain.CurrentDomain.BaseDirectory;
            Assembly assembly = Assembly.LoadFrom(curPath+"bin/DAL.dll");
            //获取类名称
            string className = ConfigurationManager.AppSettings[dalName];
            Opetate<T> dal = assembly.CreateInstance(className) as Opetate<T>;
            return dal;
        }
    }
}
