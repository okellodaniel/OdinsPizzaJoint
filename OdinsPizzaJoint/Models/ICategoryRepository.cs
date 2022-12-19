using System.Collections.Generic;

namespace OdinsPizzaJoint.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
