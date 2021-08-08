using System;
using System.Collections.Generic;
using System.Linq;
using Serviceadvisor.Data;
using Serviceadvisor.Data.DataModels;

using MongoDB.Driver;

namespace ServiceAdviserAPI_.NetCore.Services
{
    public interface IMaintenanceServiceService 
    {
       public List<Service> Get();
    }
    public class MaintenanceServiceService: IMaintenanceServiceService
    {
        private readonly IMongoCollection<Service> service;
        public MaintenanceServiceService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            service = database.GetCollection<Service>("services");
        }

        public List<Service> Get() =>
            service.Find(s => true).ToList();

        public Service Get(string id) =>
            service.Find<Service>(s => s._id == id).FirstOrDefault();

    }
}
