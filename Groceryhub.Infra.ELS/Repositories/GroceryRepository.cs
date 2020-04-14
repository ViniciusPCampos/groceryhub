using System.Collections.Generic;
using Groceryhub.Application.Repositories;
using Groceryhub.Domain.Entities;

namespace Groceryhub.Infra.ELS.Repositories
{
    public class GroceryRepository : RepositoryBase, IGroceryRepository
    {
        public void Register(Grocery grocery)
        {
            Client.IndexDocument(grocery);
        }

        public IReadOnlyCollection<Grocery> Search(string name)
        {
            var searchResponse = Client.Search<Grocery>(s =>
                s.From(0)
                    .Size(10)
                    .Query(q => 
                        q.Match((m => 
                            m.Field(f => f.Name)
                                .Query(name))))
                );
            return searchResponse.Documents;
        }
    }
}