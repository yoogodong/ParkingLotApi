using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ParkingLotApi.Models;

namespace ParkingLotApi.Repositories
{
    public class ParkingLotRepository
    {
        private IMongoCollection<ParkingLot> parkingLots; 
        public ParkingLotRepository(IOptions<MongoSetttings> settings)
        {
            MongoClient mongo = new MongoClient(settings.Value.Url);
            IMongoDatabase mongoDatabase = mongo.GetDatabase(settings.Value .Db);
            parkingLots = mongoDatabase.GetCollection<ParkingLot>(settings.Value.Document);
        }

        public async Task<string> Create(ParkingLot lot)
        {
            await parkingLots.InsertOneAsync(lot);
            return lot.Id; 
        }

    }
}
