using System.Collections.Generic;
using log4net.ElasticSearchAppender.ElasticClient;

namespace log4net.ElasticSearchAppender
{
    public interface IElasticAppenderFilter 
    {
        void PrepareConfiguration(IElasticsearchClient client);
        void PrepareEvent(Dictionary<string, object> logEvent);
    }
}
