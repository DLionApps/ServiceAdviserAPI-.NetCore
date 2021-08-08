using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Serviceadvisor.Data.DataModels
{
    [BsonIgnoreExtraElements]
    public class Service
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string serviceDate { get; set; }
        public int serviceHour { get; set; }
        public int serviceMileage { get; set; }
        public string serviiceRemarks { get; set; }
        public object[] serviceBulletins { get; set; }
        public bool isDeleted { get; set; }
        public string vehicleID { get; set; }
}
}
