using GraphQL;
using RealEstateManager.API.Queries;

namespace RealEstateManager.API.Schema
{
    public class RealEstateSchema : GraphQL.Types.Schema
    {
        public RealEstateSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<PropertyQuery>();
        }
    }
}
