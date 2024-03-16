using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_JQueuingSystem.Models
{
    public class Queue
    {
        public int queue_number { get; set; }
        public int batch_queue_number { get; set; }
        public int customer_ID { get; set; }
        public int batch_ID { get; set; }
        public String status { get; set; }
    }
}
