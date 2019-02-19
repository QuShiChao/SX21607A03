using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    //用户表
    public class ClientInfo
    {
        //编号
        [Key]
        public int Id { get; set; }
        //昵称
        public string Name { get; set; }
        //手机号码
        public string Tel { get; set; }
        //密码默认为手机号码后四位
        public string Pwd { get; set; }
        //省份Id
        [ForeignKey("P")]
        public int Pid { get; set; }
        //public virtual AddressInfo P { get; set; }
        //市级Id
        //[ForeignKey("P")]
        public int Cid { get; set; }
        //public virtual AddressInfo C { get; set; }
        //县级Id
        //[ForeignKey("P")]
        public int Aid { get; set; }
        public virtual AddressInfo P { get; set; }
        //详细地址
        public string Addr { get; set; }
        //头像
        public string HeadImage { get; set; }
    }
}
