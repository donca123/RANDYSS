using DominioMongo.Entidades;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominioMongo.Services
{
    public class IngresoServices
    {
        private IMongoCollection<IngresoControl> _gym;

       public IngresoServices(FIngresoSettings settings)
        {
            var cliente = new MongoClient(settings.Server);
            var database = cliente.GetDatabase(settings.Database);
            _gym = database.GetCollection<IngresoControl>(settings.Collection);
        }


        public List<IngresoControl> Get()
        {
            return _gym.Find(d => true).ToList();
        }

        public IngresoControl Create( IngresoControl ingreso)
        {
            _gym.InsertOne(ingreso);
            return ingreso;
        }
    }
}
