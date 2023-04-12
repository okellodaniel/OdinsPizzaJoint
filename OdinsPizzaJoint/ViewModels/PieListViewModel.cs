using System.Collections;
using System.Collections.Generic;
using OdinsPizzaJoint.Models;

namespace OdinsPizzaJoint.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }  
        public string CurrentCategory { get; set; }
    }
}
