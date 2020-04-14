using System.Collections.Generic;
using Groceryhub.Domain.Entities;

namespace Groceryhub.Application.Abstracts
{
    public interface IGroceryAppService
    {
        void Register(Grocery grocery);
        IReadOnlyCollection<Grocery> Search(string name);
    }
}