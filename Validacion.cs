using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class Validacion
    {


        public static bool esCedulaValida(string cedula)
        {
            return true;
        }


        public static bool existeCliente(string cedula)
        {
            return true;
        }

        public static bool cedulaRepetida(string cedula)
        {
            return false;
        }

        public static bool estaPlatoRegistrado(string nombre)
        {
            return true;
        }

        public static bool existePedido(string id)
        {
            return true;
        }

        public static bool existeTicket(string id)
        {
            return true;
        }
    }
}
