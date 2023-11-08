﻿using MongoDB.Bson.Serialization.Attributes;

namespace ParkingLotApi.Models
{
    public class ParkingLot
    {
        public string Name {  get; set; }
        public int Capacity {  get; set; }
        public string Location { get; set; }

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

    }
}
