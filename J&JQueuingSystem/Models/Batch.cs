using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_JQueuingSystem.Models
{
    internal class Batch
    {
        public int batch_ID { get; set; }
        public String event_type { get; set; }
        public String school_name { get; set; }
        public Double pricing{ get; set; }
    }
}
