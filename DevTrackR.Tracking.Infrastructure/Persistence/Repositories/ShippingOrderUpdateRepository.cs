using DevTrackR.Tracking.Core.Entities;
using DevTrackR.Tracking.Core.Repositories;

namespace DevTrackR.Tracking.Infrastructure.Persistence.Repositories
{
    public class ShippingOrderUpdateRepository : IShippingOrderUpdateRepository
    {
        public Task AddAsync(ShippingOrderUpdate update)
        {
            throw new NotImplementedException();
        }

        public Task<List<ShippingOrderUpdate>> GetAllByCodeAsync(string shippingOrderCode)
        {
            throw new NotImplementedException();
        }
    }
}
