using ParkingLotApi.Models;
using ParkingLotApi.Repositories;

namespace ParkingLotApi.Services
{
    public class ParkingLotService
    {
        private readonly ParkingLotRepository repository;

        public ParkingLotService(ParkingLotRepository repository)
        {
            this.repository = repository;
        }

        public async Task<string> Create(ParkingLot lot)
        {
            if (lot.Capacity <= 0)
            {
                throw new ArgumentException("capacity can not be 0 or minus");
            }
            return await repository.Create(lot);
        }
    }
}
