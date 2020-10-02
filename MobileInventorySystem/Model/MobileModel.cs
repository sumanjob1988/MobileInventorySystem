using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileInventorySystem.Model
{
    class MobileModel
    {
        [Key]
        public string Iemi { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public Nullable<int> Ram { get; set; }
        public Nullable<int> Memory { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
    }
}
