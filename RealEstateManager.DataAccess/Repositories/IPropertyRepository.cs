using RealEstateManager.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateManager.DataAccess.Repositories
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetAll();
    }
}
