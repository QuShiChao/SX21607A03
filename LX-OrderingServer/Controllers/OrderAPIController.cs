using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;

namespace LX_OrderingServer.Controllers
{
    public class OrderAPIController : ApiController
    {
        //菜系添加
        [HttpPost]
        public int AddCata(Catagery catagery)
        {
            return CatageryBll.Add(catagery);
        }
        //菜系查看
        [HttpGet]
        public List<Catagery> GetCatagery()
        {
            return CatageryBll.Get();
        }
        //菜系修改
        [HttpPut]
        public int UpdCata(Catagery catagery)
        {
            return CatageryBll.Upd(catagery);
        }
        //***菜系删除*** 
        [HttpDelete]
        public int DelCata(int id)
        {
            return CatageryBll.Del(id);
        }
        //菜肴添加
        [HttpPost]
        public int AddDish(DishInfo dish)
        {
            return DishBll.Add(dish);
        }
        //菜肴查看
        [HttpPut]
        public List<DishInfo> GetDish()
        {
            return DishBll.Get();
        }
        //菜肴修改
        [HttpPut]
        public int UpdDish(DishInfo dish)
        {
            return DishBll.Upd(dish);
        }
        //菜肴删除
        [HttpDelete]
        public int DelDish(int id)
        {
            return DishBll.Del(id);
        }
        //地址信息获取
        [HttpGet]
        public List<AddressInfo> GetAddr()
        {
            return AddrBll.Get();
        }
        //管理员注册
        [HttpPost]
        public int AddAdmin(AdministratorInfo admin)
        {
            return Adminbll.Add(admin);
        }
        //管理员登陆
        [HttpGet]
        public List<AdministratorInfo> GetAdmin()
        {
            return Adminbll.Get();
        }
        //客户注册
        [HttpPost]
        public int AddClient(ClientInfo client)
        {
            return ClientBll.Add(client);
        }
        //客户查询
        [HttpGet]
        public List<ClientInfo> GetClient()
        {
            return ClientBll.Get();
        }
        //客户修改
        [HttpPut]
        public int UpdClient(ClientInfo client)
        {
            return ClientBll.Upd(client);
        }
        //客户删除
        [HttpDelete]
        public int DelClient(int id)
        {
            return ClientBll.Del(id);
        }
        //添加评价信息
        [HttpPost]
        public int AddEvaluate(EvaluateInfo evaluate)
        {
            return EvaluateBll.Add(evaluate);
        }
        //评价信息查看
        [HttpGet]
        public List<EvaluateInfo> GetEvaluate()
        {
            return EvaluateBll.Get();
        }
        //修改评价信息
        [HttpPut]
        public int UpdEvaluate(EvaluateInfo evaluate)
        {
            return EvaluateBll.Upd(evaluate);
        }
        //删除评价信息
        [HttpDelete]
        public int DelEvaluate(int id)
        {
            return EvaluateBll.Del(id);
        }
        //物流信息添加
        [HttpPost]
        public int AddLogistics(logistics logistics)
        {
            return LogisticsBll.Add(logistics);
        }
        //物流信息获取
        [HttpGet]
        public List<logistics> GetLogistics()
        {
            return LogisticsBll.Get();
        }
        //物流信息修改
        [HttpPut]
        public int UpdLogistics(logistics logistics)
        {
            return LogisticsBll.Upd(logistics);
        }
        //添加订单
        [HttpPost]
        public int AddOrder(OrderInfo order)
        {
            return OrderBll.Add(order);
        }
        //查询订单
        [HttpGet]
        public List<OrderInfo> GetOrder()
        {
            return OrderBll.Get();
        }
        //订单删除
        [HttpDelete]
        public int DelOrder(int id)
        {
            return OrderBll.Del(id);
        }
        //订单修改
        [HttpPut]
        public int UpdOrder(OrderInfo order)
        {
            return OrderBll.Upd(order);
        }
    }
}
