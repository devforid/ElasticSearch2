using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Search.Services
{
    public class ConnectionService
    {

        public ConnectionService()
        {
            
        }

        public ElasticClient GetClient()
        {
            var settings = new ConnectionSettings(new Uri("http://localhost:9200"));

            return new ElasticClient(settings);
        }

    }
}
