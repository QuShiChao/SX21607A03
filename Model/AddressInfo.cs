using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class AddressInfo
    {
        //编号
        [Key]
        public int Id { get; set; }
        //地址信息
        public string Name { get; set; }
        //父级Id
        public int Pid { get; set; }
    }
}
