using System;
using Nest;

namespace Groceryhub.Infra.ELS.Repositories
{
    public abstract class RepositoryBase
    {
        protected readonly IElasticClient Client;

        protected RepositoryBase()
        {
            var settings = new ConnectionSettings(new Uri("http://localhost:9200"))
                .DefaultIndex("groceryhub");

            Client = new ElasticClient(settings);
        }
    }
}