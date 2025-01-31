using Examine;
using Umbraco.Core.Logging;
using Umbraco.Core.Services;

namespace Novicell.Examine.ElasticSearch
{
    public class ContentElasticSearchIndex : ElasticSearchIndex
    {
        public ContentElasticSearchIndex(string name, ElasticSearchConfig connectionConfiguration,
            IPublicAccessService publicAccessService, IProfilingLogger profilingLogger,  
            FieldDefinitionCollection fieldDefinitions = null, string analyzer = null,
            IValueSetValidator validator = null) : base(name, connectionConfiguration, publicAccessService,
            profilingLogger, fieldDefinitions, analyzer, validator)
        {
        }
    }
}