using System;
using System.Collections.Generic;
using System.Linq;
using Serviceadvisor.Data;
using Serviceadvisor.Data.DataModels;

using MongoDB.Driver;

namespace ServiceAdviserAPI_.NetCore.Services
{
    public class MaintenanceServiceService
    {
        private readonly IMongoCollection<Service> service;
        public MaintenanceServiceService(DatabaseSettings settings1)
        {
            //var client = new MongoClient(settings.ConnectionString);
            //var database = client.GetDatabase(settings.DatabaseName);

            //service = database.GetCollection<Service>("services");




            var settings = MongoClientSettings.FromConnectionString("mongodb://dbAdmin:admin@123@serviceadviserclustoron.lbukg.gcp.mongodb.net/ServiceAdviserDevDB?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("test");

        }

        public List<Service> Get() =>
            service.Find(s => true).ToList();

        public Service Get(string id) =>
            service.Find<Service>(book => book._id == id).FirstOrDefault();

    }
}
