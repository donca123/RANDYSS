using System;
using System.Collections.Generic;
using System.Text;

namespace DominioMongo.Entidades
{
    public class IngresoSettings:FIngresoSettings
    {

        public string Server { get; set; }

        public string Database { get; set; }

        public string Collection { get; set; }

    }

    public interface FIngresoSettings
    {

         string Server { get; set; }

         string Database { get; set; }

         string Collection { get; set; }

    }
}
