using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

using GraphQL;
using RealEstateManager.Utilities;
using GraphQL.Types;
using System.Linq;

namespace RealEstateManager.API.Controllers
{
    [Route("[controller]")]
    //[ApiController]
    public class GraphQLController : Controller
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _documentExecuter;

        public GraphQLController(ISchema schema,
            IDocumentExecuter documentExecuter)
        {
            _schema = schema;
            _documentExecuter = documentExecuter;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            if (query == null)
            {
                throw new ArgumentException(nameof(query));
            }

            var inputs = query.Variables?.ToInputs();
            var executionOptions = new ExecutionOptions() { 
                Schema = _schema,
                Query = query.Query,
                Inputs = inputs
            };

            var result = await _documentExecuter
                .ExecuteAsync(executionOptions);

            if (result.Errors.Any())
            {
                return BadRequest(result);
            }

            return Ok(result);

        }
    }
}
