using DevTrackR.Tracking.Application.Models.InputModels;
using DevTrackR.Tracking.Application.Models.ViewModels;

namespace DevTrackR.Tracking.Application.Services
{
    public class ShippingOrderUpdateService : IShippingOrderUpdateService
    {
        public Task AddUpdate(AddShippingOrderUpdateInputModel model)
        {
            throw new NotImplementedException();
        }

        public Task<List<ShippingOrderUpdateViewModel>> GetAllByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}
