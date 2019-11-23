using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Control {

    public class controlRes
    {
        TechRes TR = new TechRes();

        public int IniciarSesion(string correo, string contra)
        {
            if (correo != "" && contra != "")
            {
                return TR.IniciarSesion(correo, contra);
            }
            else
            {
                return 0;
            }
        }

        public bool Registrarse(string nombre, string correo, string contra)
        {
            if (nombre != "" && correo != "" && contra != "")
            {
                return TR.Registrarse(nombre, correo, contra);
            }
            else
            {
                return false;
            }
        }
    }
}