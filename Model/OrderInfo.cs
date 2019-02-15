using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    //订单表
    public class OrderInfo
    {
        //编号
        [Key]
        public int Id { get; set; }
        //顾客Id
        [ForeignKey("Client")]
        public int Cid { get; set; }
        public virtual ClientInfo Client { get; set; }
        //菜色Id
        [ForeignKey("Dish")]
        public int Did { get; set; }
        public virtual DishInfo Dish { get; set; }
        //数量
        public int Num { get; set; }
        //订单类型：订餐0、就餐1
        public int OrderType { get; set; }
        //总价
        public decimal Total { get; set; }
        //留言
        public string Leave { get; set; }
        //订单状态：未付款0、已付款1、未评价2、已评价3
        public int Status { get; set; }
        //订购时间
        public DateTime OrderTime { get; set; }
    }
}
