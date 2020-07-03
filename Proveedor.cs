using System;
using System.Collections.Generic;
using System.Linq;
namespace Farmacia
{
    class Proveedor
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cuidad { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public Proveedor(string codigo, string nombre, string apellido, string cuidad, string direccion, string telefono)
        {
            this.codigo = codigo ;
            this.nombre = nombre ;
            this.apellido = apellido ;
            this.cuidad = cuidad;
            this.direccion = direccion ;
            this.telefono = telefono ;
        }
        public static List<Proveedor> Proveedores = new List<Proveedor>();
        public static void Ingresar(Proveedor proveedor)
        {
            Proveedores.Add(proveedor);
        }

        public static void Enlistar()
        {
            Console.WriteLine("Total de proveedores: {0}", Proveedores.Count());
            Console.WriteLine("--------------NÓMINA DE PROVEEDORES--------------");
            foreach (Proveedor proveedor in Proveedores)
            {
                Imprimir(proveedor);
            }
        }
        public static void Imprimir(Proveedor proveedor)
        {
            Console.WriteLine("código: {0} | nombre: {1} | apellido: {2} | cuidad: {3} | dirección: {4} | telefono: {5}", proveedor.codigo,
            proveedor.nombre, proveedor.apellido, proveedor.cuidad, proveedor.direccion, proveedor.telefono);

        }
        public static Proveedor Buscar(string codigo)
        {
            foreach (Proveedor proveedor in Proveedores)
            {
                if (proveedor.codigo.Equals(codigo))
                {
                    return proveedor;
                }
            }
            return null;
        }
        public static bool Eliminar(string codigo)
        {
            Proveedor proveedor = Buscar(codigo);
            if (proveedor != null)
            {
                Proveedores.Remove(proveedor);
                return true;
            }
            return false;
        }
          public static bool Modificar(string nombre, string nuevoNombre)
        {
            foreach (Proveedor proveedor in Proveedores)
            {
                if (proveedor.nombre.Equals(nombre))
                {
                    proveedor.nombre = nuevoNombre;
                    return true;
                }
            }
            return false;
        }
    }
}
