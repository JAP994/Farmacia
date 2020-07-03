using System;
using System.Collections.Generic;
using System.Linq;
namespace Farmacia
{
    class Medicamento
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public int cantidadStock { get; set; }
        public string tipoMedicamento { get; set; }
        public Medicamento(string codigo, string nombre, float precio, int cantidadStock, string tipoMedicamento)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidadStock =cantidadStock;
            this.tipoMedicamento = tipoMedicamento;
        }
        public static List<Medicamento> Medicamentos = new List<Medicamento>();
        public static void Ingresar(Medicamento medicamento)
        {
            Medicamentos.Add(medicamento);
        }

        public static void Enlistar()
        {
            Console.WriteLine("Total de Medicamento: {0}", Medicamentos.Count());
            Console.WriteLine("--------------NÓMINA MEDICAMENTOS--------------");
            foreach (Medicamento medicamento in Medicamentos)
            {
                Imprimir(medicamento);
            }
        }
        public static void Imprimir(Medicamento medicamento)
        {
            Console.WriteLine("código: {0} | nombre: {1} | precio: {2}  | stock: {3} | Tipo de medicamento: {4}", medicamento.codigo,
            medicamento.nombre, medicamento.precio, medicamento.cantidadStock, medicamento.tipoMedicamento);

        }
        public static Medicamento Buscar(string codigo)
        {
            foreach (Medicamento medicamento in Medicamentos)
            {
                if (medicamento.codigo.Equals(codigo))
                {
                    return medicamento;
                }
            }
            return null;
        }
        public static bool Eliminar(string codigo)
        {
            Medicamento medicamento = Buscar(codigo);
            if (medicamento != null)
            {
                Medicamentos.Remove(medicamento);
                return true;
            }
            return false;
        }
        public static bool Modificar(string nombre, string nuevoNombre)
        {
            foreach (Medicamento medicamento in Medicamentos)
            {
                if (medicamento.nombre.Equals(nombre))
                {
                    medicamento.nombre = nuevoNombre;
                    return true;
                }
            }
            return false;
        }
    }
}
