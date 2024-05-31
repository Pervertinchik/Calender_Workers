using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender_KMVHP.Models
{
    public class Day
    {
        public int Id { get; set; }
        
        public int Number_day {  get; set; }    
        public string State { get; set; }

        [ForeignKey("MonthhId")]
        public Monthh Monthh { get; set; }
        public int MonthhId { get; set; }



    }
}
