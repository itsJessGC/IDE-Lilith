using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilith
{
    class Nodo
    {
        //declaramos los nodos, hijos y hermanos
        public Nodo[] hijos;
        public Nodo hermano;
        public string valor;
        public int linea;

        //los inicializamos
        public Nodo()
        {
            hijos = new Nodo[3];
            hermano = null;
            valor = "";
            linea = 0;
        }

        //obtenemos los valores de los tokens
        public Nodo(token token)
        {
            hijos = new Nodo[3];
            hermano = null;
            valor = token.getLexema();
            linea = token.getLinea();
        }
    }
}
