using RealEstateManager.Database;
using RealEstateManager.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateManager.DataAccess.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly RealEstateContext _dbContext;
        public PropertyRepository(RealEstateContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Property> GetAll()
        {
            return _dbContext.Properties;
        }
    }
}
