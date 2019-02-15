using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;

namespace DAL
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext() : base("con")
        { }
        public virtual DbSet<ClientInfo> Client { get; set; }
        public virtual DbSet<AddressInfo> Address { get; set; }
        public virtual DbSet<AdministratorInfo> Administrator { get; set; }
        public virtual DbSet<Catagery> Catagery { get; set; }
        public virtual DbSet<DishInfo> Dish { get; set; }
        public virtual DbSet<OrderInfo> Order { get; set; }
        public virtual DbSet<EvaluateInfo> Evaluate { get; set; }
        public virtual DbSet<logistics> Logistics { get; set; }
    }
}
