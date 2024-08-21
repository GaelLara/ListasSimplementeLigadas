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
        // CUANDO EL ENLACE SEA NULL , LA LISTA ESTARA VACIA
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
        // ELIMINAR DATOS DE LA LISTA
        public void Vaciar()
        {
            _nodoIncial.Enlace = null;
        }
        // AGREGAR DATOS A LA LISTA
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
        // ESTE METODO SIRVE PARA QUE LA CONSOLA TE DE UN DATO EN ESPECIFICO
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
        // SIRVE PARA BUSCAR ELEMENTOS DENTRO DE LA LISTA
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
        // ESTE METODO SIRVE PARA BUSCAR EL DATO ANTERIOR, TE AYUDA CUANDO QUIERES ELIMINAR UN DATO         
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
        //SIRVE PARA ELIMINAR DATOS
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

