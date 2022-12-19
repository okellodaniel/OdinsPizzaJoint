using System.Collections.Generic;

namespace OdinsPizzaJoint.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int PieId);
    }
}
