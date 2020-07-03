using System;
using System.Collections.Generic;
using System.Linq;
namespace Farmacia
    {
        class Cliente
        {
            public string codigo { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string direccion { get; set; }
            public string telefono { get; set; }
            public Cliente(string codigo, string nombre, string apellido, string direccion, string telefono)
            {
                this.codigo = codigo;
                this.nombre = nombre;
                this.apellido = apellido;
                this.direccion = direccion;
                this.telefono = telefono;
            }
            public static List<Cliente> Clientes = new List<Cliente>();
            public static void Ingresar(Cliente cliente)
            {
                Clientes.Add(cliente);
            }

            public static void Enlistar()
            {
                Console.WriteLine("Total de Clientes: {0}", Clientes.Count());
                Console.WriteLine("--------------NÓMINA DE Clientes--------------");
                foreach (Cliente cliente in Clientes)
                {
                    Imprimir(cliente);
                }
            }
            public static void Imprimir(Cliente cliente)
            {
                Console.WriteLine("código: {0} | nombre: {1} | apellido: {2}  | dirección: {3} | telefono: {4}", cliente.codigo,
                cliente.nombre, cliente.apellido, cliente.direccion, cliente.telefono);

            }
            public static Cliente Buscar(string codigo)
            {
                foreach (Cliente cliente in Clientes)
                {
                    if (cliente.codigo.Equals(codigo))
                    {
                        return cliente;
                    }
                }
                return null;
            }
            public static bool Eliminar(string codigo)
            {
                Cliente cliente = Buscar(codigo);
                if (cliente != null)
                {
                    Clientes.Remove(cliente);
                    return true;
                }
                return false;
            }
            public static bool Modificar(string nombre, string nuevoNombre)
            {
                foreach (Cliente cliente in Clientes)
                {
                    if (cliente.nombre.Equals(nombre))
                    {
                        cliente.nombre = nuevoNombre;
                        return true;
                    }
                }
                return false;
            }
        }
    }
