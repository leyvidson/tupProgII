using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Entidades
{
    public class Cliente
    {
        public int Id_cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_nacimiento { get; set;}

        public Cliente(int id_cliente, string nombre, string apellido, DateTime fecha_nacimiento)
        {
            Id_cliente = id_cliente;
            Nombre = nombre;
            Apellido = apellido;
            Fecha_nacimiento = fecha_nacimiento;
        }

        public Cliente()
        {
        }

        public override string ToString()
        {
            return Nombre + Apellido;
        }
    }
}
