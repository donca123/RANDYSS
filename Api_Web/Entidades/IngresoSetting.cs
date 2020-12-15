using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Web.Entidades
{
    public class IngresoSetting : InterfaceIngreso
    {


        public string Server { get; set; }

        public string Database { get; set; }

        public string Collection { get; set; }


    }

        public interface InterfaceIngreso
        {

            string Server { get; set; }

            string Database { get; set; }

            string Collection { get; set; }

        }
    }
