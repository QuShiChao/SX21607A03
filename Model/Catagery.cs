using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Catagery
    {
        //编号
        [Key]
        public int Id { get; set; }
        //类型名称
        public string Name { get; set; }
    }
}
