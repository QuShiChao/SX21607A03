using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    //物流类
    public class logistics
    {
        [Key]
        public int Id { get; set; }
        //菜色Id
        [ForeignKey("Order")]
        public int Oid { get; set; }
        public virtual OrderInfo Order { get; set; }
        //状态 待配送0 已配送1 已送达2
        public int Status { get; set; }
        //时间
        public DateTime Ltime { get; set; }
    }
}
