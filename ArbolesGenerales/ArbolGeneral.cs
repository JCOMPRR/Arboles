using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesGenerales
{
    public class ArbolGeneral
    {
        private readonly Nodo raiz;

        //public Nodo Raiz => raiz; (Hace lo mismo que el de abajo)
        public Nodo Raiz { get { return raiz; } }

        public ArbolGeneral(string dato)
        {
            raiz = new Nodo(dato);
        }

        public Nodo InsertarHijo(Nodo padre,string dato)
        {
            if (string.IsNullOrWhiteSpace(dato)) {
                throw new Exception("El dato esta vacio");
            }

            if(padre is null)
            {
                throw new Exception("El padre no puede ser nulo");
            }

            if(padre.Hijo is null)
            {
                padre.Hijo = new Nodo(dato);
                return padre.Hijo;
            }

            else
            {
                Nodo hijoActual = padre.Hijo;

                while (hijoActual.Hermano != null) 
                {
                    hijoActual = hijoActual.Hermano;
                }

                hijoActual.Hermano = new Nodo(dato);
                return hijoActual.Hermano;
            }
            //Tarea: Recorrer el arbol (), buscar arbol (Regresa Nodo) y obtener 
    }
}
