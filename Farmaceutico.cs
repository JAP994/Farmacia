using System;
using System.Collections.Generic;
using System.Linq;
namespace Farmacia
    {
        class Farmaceutico
        {
            public string codigo { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string sexo { get; set; }
            public string direccion { get; set; }
            public string telefono { get; set; }
            public string correo { get; set; }
            public Farmaceutico(string codigo, string nombre, string apellido,string sexo, string direccion, string telefono, string correo)
            {
                this.codigo = codigo;
                this.nombre = nombre;
                this.apellido = apellido;
                this.sexo = sexo;
                this.direccion = direccion;
                this.telefono = telefono;
                this.correo =correo;
            }
            public static List<Farmaceutico> Farmaceuticos = new List<Farmaceutico>();
            public static void Ingresar(Farmaceutico farmaceutico)
            {
                Farmaceuticos.Add(farmaceutico);
            }

            public static void Enlistar()
            {
                Console.WriteLine("Total de Farmaceuticos: {0}", Farmaceuticos.Count());
                Console.WriteLine("--------------NÓMINA DE FARMACEUTICOS--------------");
                foreach (Farmaceutico farmaceutico in Farmaceuticos)
                {
                    Imprimir(farmaceutico);
                }
            }
            public static void Imprimir(Farmaceutico farmaceutico)
            {
                Console.WriteLine("código: {0} | nombre: {1} | apellido: {2} | sexo: {3}  | dirección: {4} | telefono: {5} | correo: {6}", farmaceutico.codigo,
                farmaceutico.nombre, farmaceutico.apellido, farmaceutico.sexo, farmaceutico.direccion, farmaceutico.telefono, farmaceutico.correo);

            }
            public static Farmaceutico Buscar(string codigo)
            {
                foreach (Farmaceutico farmaceutico in Farmaceuticos)
                {
                    if (farmaceutico.codigo.Equals(codigo))
                    {
                        return farmaceutico;
                    }
                }
                return null;
            }
            public static bool Eliminar(string codigo)
            {
                Farmaceutico farmaceutico = Buscar(codigo);
                if (farmaceutico != null)
                {
                    Farmaceuticos.Remove(farmaceutico);
                    return true;
                }
                return false;
            }
            public static bool Modificar(string nombre, string nuevoNombre)
            {
                foreach (Farmaceutico farmaceutico in Farmaceuticos)
                {
                    if (farmaceutico.nombre.Equals(nombre))
                    {
                        farmaceutico.nombre = nuevoNombre;
                        return true;
                    }
                }
                return false;
            }
        }
    }
