using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechRestaurant
{
    public class Restaurante
    {
        static int _idRestaurante = 0;

        public static int IdRestaurante
        {
            get
            {
                return _idRestaurante;
            }
            set
            {
                _idRestaurante = value;
            }
        }
    }
}