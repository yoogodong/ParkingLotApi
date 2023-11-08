using MongoDB.Driver;
using ParkingLotApi.Models;

namespace ParkingLotApi.Repositories
{
    public class ParkingLotRepository
    {
        private IMongoCollection<ParkingLot> parkingLots; 
        public ParkingLotRepository(IMongoClient mongo)
        {
            IMongoDatabase mongoDatabase = mongo.GetDatabase("AFS");
            parkingLots = mongoDatabase.GetCollection<ParkingLot>("ParkingLot");
        }

        public async Task<string> Create(ParkingLot lot)
        {
            await parkingLots.InsertOneAsync(lot);
            return lot.Id; 
        }

    }
}
