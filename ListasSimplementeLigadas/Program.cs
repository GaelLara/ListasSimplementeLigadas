namespace ListasSimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.Agregar("A");
            lista.Agregar("B");
            lista.Agregar("C");
            lista.Agregar("D");
            lista.Agregar("E");
            lista.Agregar("F");
            Console.WriteLine(lista.ObtenerDatos());

            Console.WriteLine();
            Console.WriteLine("BUSCANDO A D");
            Nodo nodoD = lista.Buscar("D");
            Console.WriteLine(nodoD.Valor);

            Console.WriteLine();
            Console.WriteLine("BUSCANDO A ANTERIOR A D");
            Nodo nodoAnteriorD = lista.BuscarAnterior("D");
            Console.WriteLine(nodoAnteriorD.Valor);

            Console.WriteLine();
            Console.WriteLine("ELIMINANDO A D");
            lista.Eliminar("D");
            Console.WriteLine(lista.ObtenerDatos());


        }
    }
}
