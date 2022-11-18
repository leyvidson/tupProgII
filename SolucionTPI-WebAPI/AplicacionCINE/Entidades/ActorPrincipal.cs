using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Entidades
{
    public class ActorPrincipal
    {
        public int Id_actor_principal { get; set; }
        public string Nombre { get; set; }

        public ActorPrincipal(int id_actor_principal, string nombre)
        {
            Id_actor_principal = id_actor_principal;
            Nombre = nombre;
        }

        public ActorPrincipal()
        {
            Id_actor_principal = 0;
            Nombre = string.Empty;
        }
      
    }
}
