using System.Text;

namespace ListasSimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoIncial;
        public Lista()
        {
            _nodoIncial = new Nodo();
        }

        private bool EstaVacia()
        {
            if (_nodoIncial.Enlace == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Vaciar()
        {
            _nodoIncial.Enlace = null;
        }

        public void Agregar(string valor)
        {
            Nodo nodoActual = _nodoIncial;
            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
            }

            Nodo nodoNuevo = new Nodo(valor);
            nodoActual.Enlace = nodoNuevo;
        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            Nodo nodoActual = _nodoIncial;
            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
                datos.AppendLine(nodoActual.Valor);
            }
            return datos.ToString();
        }

        public Nodo Buscar(string valor)
        {
            Nodo nodoActual = _nodoIncial;
            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
                if (nodoActual.Valor == valor)
                {
                    return nodoActual;
                }
            }
            return null;
        }

        public Nodo BuscarAnterior(string valor)
        {
            Nodo nodoActual = _nodoIncial;
            while (nodoActual.Enlace != null)
            {
                if (nodoActual.Enlace.Valor == valor)
                {
                    return nodoActual;
                }
                nodoActual = nodoActual.Enlace;
            }
            return null;
        }

        public void Eliminar(string valor) 
        {
        Nodo nodoActual = Buscar(valor);
            if (nodoActual != null) 
            {
                Nodo nodoAnterior = BuscarAnterior(valor);
                if (nodoAnterior != null)
                {
                    nodoAnterior.Enlace = nodoActual.Enlace;
                    nodoActual.Enlace = null;
                                                                                                                                                                    
                }
                    
            }
        }


    }
}

