﻿using Practica01.Models;
using Practica01.Service;

namespace Practica01.Bussines
{
    public class Operaciones : IOperaciones
    {
        public double Division(Acciones acciones)
        {
            throw new NotImplementedException();
        }

        public double Multiplicacion(Acciones acciones)
        {
            throw new NotImplementedException();
        }

        public double Resta(Acciones acciones)
        {
            throw new NotImplementedException();
        }

        public double Suma(Acciones acciones)
        {
            return acciones.DatoN1 + acciones.DatoN2;
        }
    }
}
