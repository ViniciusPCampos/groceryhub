using System.Collections.Generic;
using Groceryhub.Domain.Entities;

namespace Groceryhub.Application.Repositories
{
    public interface IGroceryRepository
    {
        void Register(Grocery grocery);
        IReadOnlyCollection<Grocery> Search(string name);
    }
}