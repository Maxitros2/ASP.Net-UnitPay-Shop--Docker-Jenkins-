using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmgShop.Models
{
    public class Donator
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Donate { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
