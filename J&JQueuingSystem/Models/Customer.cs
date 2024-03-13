using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_JQueuingSystem.Models
{
    internal class Customer
    {
        public int ID { get; set; }
        public String name { get; set; }
        public String contact { get; set; }
        public String account_name { get; set; }
        public String section { get; set; }
        public String course { get; set; }
        public String batch_queue_number { get; set; }
        public String batch_ID { get; set; }
    }
}
