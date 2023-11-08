using ParkingLotApi.Models;

namespace ParkingLotApi.Repositories
{
    public class ParkingLotRepository
    {
       

        public async Task<string> Create(ParkingLot lot)
        {
            return  await Task.FromResult(lot.Name);
        }

    }
}
