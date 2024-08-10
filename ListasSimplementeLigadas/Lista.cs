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
    }
}

