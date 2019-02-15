using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class EvaluateInfo
    {
        //编号
        [Key]
        public int Id { get; set; }
        //客户Id
        [ForeignKey("Client")]
        public int Cid { get; set; }
        public virtual ClientInfo Client { get; set; }
        //菜色Id
        [ForeignKey("Dish")]
        public int Did { get; set; }
        public virtual DishInfo Dish { get; set; }
        //评价内容
        public string Evaluate { get; set; }
        //评价时间
        public DateTime ETime { get; set; }
    }
}
