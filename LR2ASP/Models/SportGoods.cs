using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LR2ASP.Models
{
    public class SportGoods
    {
        public int Good_Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public int Count { get; set; }
        public string Category { get; set; }
    }
}