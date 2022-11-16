﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionCINE.Datos;
using AplicacionCINE.Entidades;
using AplicacionCINE.Servicios.Interfaz;

namespace AplicacionCINE.Servicios.Implementacion
{
    class Servicio : IServicio
    {
        private IReservas oDao;
        
        public Servicio()
        {
            oDao = new ReservasDAO();
        }

        public DataTable ConsultaDBVista(string vista)
        {
            return oDao.ConsultaDBVista(vista);
        }

        public DataTable ConsultarDB(string SP)
        {
            return oDao.ConsultarDB(SP);
        }
              

        public bool EjecutarInsert(object obj)
        {
            return (obj.Equals(obj)); // el equals esta para que no de error nomas . ES UNA PRUEBA DE REFACTORIZACION
        }

        public bool EjecutarInsert(Pelicula pelicula)
        {
            return oDao.EjecutarInsert(pelicula);
        }

        public bool EjecutarInsert(Cliente cliente)
        {
            return oDao.EjecutarInsert(cliente);
        }

        public bool EjecutarInsert(Reserva reserva)
        {
            return oDao.EjecutarInsert(reserva);
        }
    }
}