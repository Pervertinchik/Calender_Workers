using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender_KMVHP.Models
{
    public class Monthh {


     public int MonthhId {  get; set; }

     public string Name_month {  get; set; }   
     public List<Day> Days { get; set; }


     [ForeignKey("WorkerId")]
     public Worker Worker { get; set; }
     public int WorkerId { get; set; }






    }
}
