using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DominioMongo.Entidades
{
   public  class IngresoControl
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("usuario")]
        public string Usuario { get; set; }

        [BsonElement("ingreso")]
        public string HoraIngreso {get; set;}


    }
}
