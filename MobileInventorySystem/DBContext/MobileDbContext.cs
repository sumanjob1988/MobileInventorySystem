using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using MobileInventorySystem.Model;

namespace MobileInventorySystem.DBContext
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class MobileDbContext : DbContext
    {
        //Add your Dbsets here
        public DbSet<MobileModel> Mobiles { get; set; }
        public MobileDbContext() : base("MobileDb")
        { 
        
        }
    }
}
