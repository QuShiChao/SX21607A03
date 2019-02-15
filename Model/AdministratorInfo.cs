using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class AdministratorInfo
    {
        //编号
        [Key]
        public int Id { get; set; }
        //姓名
        public string Name { get; set; }
        //密码
        public string Pwd { get; set; }
    }
}
