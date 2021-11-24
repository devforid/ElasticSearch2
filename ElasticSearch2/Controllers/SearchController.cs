using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Search.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticSearch.Controllers
{
    [ApiController]
    [Route("api/Partner")]

    public class SearchController : ControllerBase
    {
        private readonly SearchService _searchService;
        public SearchController(SearchService searchService)
        {
            this._searchService = searchService;
        }

        [HttpPost]
        public bool GetItems()
        {
            this._searchService.SetData();
            return true;
        }
    }
}
