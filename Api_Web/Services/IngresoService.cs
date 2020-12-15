using Api_Web.Entidades;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Services
{
    public class IngresoServices
    {
        private IMongoCollection<Ingreso> _gym;

        public IngresoServices(InterfaceIngreso settings)
        {
            var cliente = new MongoClient(settings.Server);
            var database = cliente.GetDatabase(settings.Database);
            _gym = database.GetCollection<Ingreso>(settings.Collection);
        }


        public List<Ingreso> Get()
        {
            return _gym.Find(d => true).ToList();
        }

        public Ingreso Create(Ingreso ingreso)
        {
            _gym.InsertOne(ingreso);
            return ingreso;
        }
    }
}
