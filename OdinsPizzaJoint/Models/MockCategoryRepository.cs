using System.Collections.Generic;

namespace OdinsPizzaJoint.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>()
        {
            new Category{CategoryId=1,CategoryName="Fruit Pies",Description="All-Fruity pies"},
            new Category{CategoryId=2,CategoryName="Cheese cakes",Description="Cheesy all the way"},
            new Category{CategoryId=3,CategoryName="Seasonal pies",Description="Get in the mood for seasonal pies"}
        };
    }
}
