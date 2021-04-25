using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

using GraphQL;
using RealEstateManager.Utilities;

namespace RealEstateManager.API.Controllers
{
    [Route("[controller]")]
    //[ApiController]
    public class GraphQLController : Controller
    {
        public GraphQLController()
        {

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            if (query == null)
            {
                throw new ArgumentException(nameof(query));
            }

            var inputs = query.Variables?.ToInputs();

            //return Ok();
        }
    }
}
