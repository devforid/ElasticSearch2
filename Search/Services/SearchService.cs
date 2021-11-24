using Nest;
using Search.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Search.Services
{
    public class SearchService
    {
        private readonly ConnectionService _connectionService;
        private readonly ElasticClient elasticClient;
        public SearchService(ConnectionService connectionService)
        {
            this._connectionService = connectionService;
            this.elasticClient = this._connectionService.GetClient();
        }

        public bool SetData()
        {
            var contact = new Contact()
            {
                ItemId = "1",
                Name = "Anybody",
                PhoneNumber = "6666666666",
                Address = "Ekhane"
            };

            var response = this.elasticClient.IndexDocument(contact);
            return true;
        }

        public bool GetSearchedData(string name)
        {
            return true;
        }
    }
}
