using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class DishInfo
    {
        //编号
        [Key]
        public int Id { get; set; }
        //名称
        public string Name { get; set; }
        //价格
        public decimal Price { get; set; }
        //菜系ID
        [ForeignKey("Cata")]
        public int Cid { get; set; }
        public virtual Catagery Cata { get; set; }
        //图片路径
        public string Image { get; set; }
        //菜色介绍
        public string Intro { get; set; }
        //菜色状态：0有，1无，2特色菜,3下架
        public int Status { get; set; }
        //订购次数
        public int OrderNums { get; set; }
        //被顶次数
        public int Up { get; set; }
        //被踩次数
        public int Down { get; set; }
    }
}
