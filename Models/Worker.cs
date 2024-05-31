using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender_KMVHP.Models
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string Name { get; set; }

        public List<Monthh> months { get; set; }

    }
}
