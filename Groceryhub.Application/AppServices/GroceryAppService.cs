using System.Collections.Generic;
using Groceryhub.Application.Abstracts;
using Groceryhub.Application.Repositories;
using Groceryhub.Domain.Entities;

namespace Groceryhub.Application.AppServices
{
    public class GroceryAppService : IGroceryAppService
    {
        private readonly IGroceryRepository _groceryRepository;

        public GroceryAppService(IGroceryRepository groceryRepository)
        {
            _groceryRepository = groceryRepository;
        }

        public void Register(Grocery grocery)
        {
            _groceryRepository.Register(grocery);
        }

        public IReadOnlyCollection<Grocery> Search(string name)
        {
            return _groceryRepository.Search(name);
        }
    }
}