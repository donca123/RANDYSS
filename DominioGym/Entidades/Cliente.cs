using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DominioGym
{
    public class Cliente:Persona
    {
        [Key]
        public int IdCliente { get; set; }



        public static Cliente nuevoCliente(string _nombres, string _paterno, 
            string _materno, int _telefono, string _direccion, int _dni)
        {
            return new Cliente
            {
                Nombres = _nombres,
                ApellidoP = _paterno,
                ApellidoM = _materno,
                Telefono = _telefono,
                Direccion = _direccion,
                Dni = _dni

            };
        }

        public void modificarCliente(string _nombres, string _paterno,
            string _materno, int _telefono, string _direccion, int _dni)
        {
            Nombres = _nombres;
            ApellidoP = _paterno;
            ApellidoM = _materno;
            Telefono = _telefono;
            Direccion = _direccion;
            Dni = _dni;
           
        }

        public void anularEstado()
        {
            Estado = false;
        }

        public ICollection<Cliente> listarCliente()
        {
            return listarCliente();
        }
    }
}
