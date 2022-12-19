using System.Collections.Generic;
using System.Linq;

namespace OdinsPizzaJoint.Models
{
    public class MockPieRepository : IPieRepository
    {
        public readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => new List<Pie>()
        {
            new Pie{PieId=1,Name="Strawberry pie",Price=15.9M,ShortDescription="Lo rem gypsum"},
            new Pie{PieId=2,Name="Cheese cake",Price=15.9M,ShortDescription="Lo rem gypsum"},
            new Pie{PieId=3,Name="Rhubarb pie",Price=15.9M,ShortDescription="Lo rem gypsum"},
            new Pie{PieId=4,Name="Pumpkin pie",Price=15.9M,ShortDescription="Lo rem gypsum"}
        };

        public IEnumerable<Pie> PiesOfTheWeek { get; set; }

        public Pie GetPieById(int PieId)
        {
            return AllPies.FirstOrDefault(x => x.PieId == PieId); 
        }
    }
}
