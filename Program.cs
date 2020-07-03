using System;


namespace Farmacia
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            Medicamento.Ingresar(new Medicamento("1", "PARACETAMOL", 12, 25, "Generico"));
            Medicamento.Ingresar(new Medicamento("2", "ASPIRINA", 5, 20, "Generico"));
            Medicamento.Ingresar(new Medicamento("3", "RIFAXIMINA", 1, 625, "Generico"));
            Medicamento.Ingresar(new Medicamento("4", "FEBUXOSTAT", 3, 825, "Generico"));
            Medicamento.Ingresar(new Medicamento("5", "ANFOTERICINA B COMPLEJO LIPÍDICO", 8, 250, "Generico"));
            Medicamento.Ingresar(new Medicamento("6", "LORNOXICAM", 4, 655, "Generico"));
            Proveedor.Ingresar(new Proveedor("1", "Carlos", "Paez", "Quito", "El Carmen", "0987611323"));
            Proveedor.Ingresar(new Proveedor("2", "Jorge", "Viteri", "Guayaquil", "Isla Trinitaria", "0987654323"));
            Proveedor.Ingresar(new Proveedor("3", "Omar", "Andrango", "Cuenca", "El sender", "0985654323"));
            Proveedor.Ingresar(new Proveedor("4", "Pedro", "Castro", "Ambato", "La cocha", "0987654777"));
            Farmaceutico.Ingresar(new Farmaceutico("1", "Jonathan", "Sánchez", "Masculino", "El beaterio", "0933332234", "sanchez@gmail.com"));
            Farmaceutico.Ingresar(new Farmaceutico("2", "Felipe", "Campaña", "Masculino", "Sangolqui", "0987555667", "felipegmail.com"));
            Farmaceutico.Ingresar(new Farmaceutico("3", "Oscar", "Tipan", "Masculino", "Caupicho", "0987474274", "oscar@gmail.com"));
            do
            {
                Console.WriteLine("....Bienvenido, Farmacia CAD....");
                Console.WriteLine("................................");
                Console.WriteLine("1. Ingresar Proveedor");
                Console.WriteLine("2. Ingresar Medicamento");
                Console.WriteLine("3. Ingresar Farmaceutico");
                Console.WriteLine("4. Realizar Venta");
                Console.WriteLine("0. Salir");
                Console.WriteLine("................................");
                Console.WriteLine("Elige una opcion:");
                opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        string opcion1;
                        string codigo, nombre, apellido, cuidad, direccion, telefono, respuesta;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("................................");
                            Console.WriteLine("1. Ingresar Proveedor");
                            Console.WriteLine("2. Modificar Proveedor");
                            Console.WriteLine("3. Eliminar Proveedor");
                            Console.WriteLine("4. Imprimir Proveedores");
                            Console.WriteLine("5. Buscar Proveedor");
                            Console.WriteLine("6. Regresar");
                            opcion1 = Console.ReadLine();
                            switch (opcion1)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese Código");
                                    codigo = Console.ReadLine();
                                    Console.WriteLine("Ingrese Nombre ");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("Ingrese Apellido");
                                    apellido = Console.ReadLine();
                                    Console.WriteLine("Ingrese Cuidad");
                                    cuidad = Console.ReadLine();
                                    Console.WriteLine("Ingrese Dirección");
                                    direccion = Console.ReadLine();
                                    Console.WriteLine("Ingrese Telefono");
                                    telefono = Console.ReadLine();
                                    Proveedor proveedor = new Proveedor(codigo, nombre, apellido, cuidad, direccion, telefono);
                                    Proveedor.Ingresar(proveedor);
                                    Console.Clear();
                                    Console.WriteLine("Proveedor Guardado con exito.");
                                    Console.WriteLine("Presione cualquier tecla para regresar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el Código del proveedor que va a buscar para modificar.");
                                    respuesta = Console.ReadLine();
                                    proveedor = Proveedor.Buscar(respuesta);
                                    if (proveedor == null)
                                    {
                                        Console.WriteLine("El proveedor no existe.");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Proveedor.Imprimir(proveedor);
                                        string nuevoNombre = proveedor.nombre;
                                        Console.WriteLine("Elija la opcion que desee modificar");
                                        Console.WriteLine("1. Nombre");
                                        opcion1 = Console.ReadLine();
                                        switch (opcion1)
                                        {
                                            case "1":
                                                Console.WriteLine("................................");
                                                Console.WriteLine("Ingrese un nuevo nombre");
                                                respuesta = Console.ReadLine();
                                                if (Proveedor.Modificar(nuevoNombre, respuesta))
                                                {
                                                    Console.WriteLine("Su nuevo nombre es : " + proveedor.nombre);
                                                }
                                                break;
                                        }
                                    }
                                    Console.Clear();
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el Código del proveedor que va a eliminar");
                                    respuesta = Console.ReadLine();
                                    proveedor = Proveedor.Buscar(respuesta);
                                    if (proveedor == null)
                                    {
                                        Console.WriteLine("No existe ");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Proveedor.Eliminar(respuesta);
                                    }
                                    Console.Clear();
                                    break;
                                case "4":
                                    Proveedor.Enlistar();
                                    Console.WriteLine("Presione cualquier tecla para regresar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "5":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el Código del proveedor que va a buscar");
                                    respuesta = Console.ReadLine();
                                    proveedor = Proveedor.Buscar(respuesta);
                                    if (proveedor == null)
                                    {
                                        Console.WriteLine("El proveedor no existe");
                                        Console.WriteLine("................................");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Proveedor.Imprimir(proveedor);
                                        Console.WriteLine("................................");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    Console.Clear();

                                    break;
                                case "6":
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("................................");
                                    Console.WriteLine("No se ha selecionado ninguna opción.");
                                    Console.WriteLine("Presione cualquier tecla para regresar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        } while (opcion1 != "6");
                        break;
                    case "2":
                        string opcion2;
                        string codigo2, nombre2, tipo2, respuesta2;
                        float precio2;
                        int stock2;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("................................");
                            Console.WriteLine("1. Ingresar Medicamento");
                            Console.WriteLine("2. Modificar Medicamento");
                            Console.WriteLine("3. Eliminar Medicamento");
                            Console.WriteLine("4. Imprimir Medicamentos");
                            Console.WriteLine("5. Buscar Medicamento");
                            Console.WriteLine("6. Regresar");
                            opcion2 = Console.ReadLine();
                            switch (opcion2)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese Código");
                                    codigo2 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Nombre ");
                                    nombre2 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Precio");
                                    precio2 = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese Stock");
                                    stock2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el tipo de medicamento");
                                    tipo2 = Console.ReadLine();
                                    Medicamento medicamento = new Medicamento(codigo2, nombre2, precio2, stock2, tipo2);
                                    Medicamento.Ingresar(medicamento);
                                    Console.Clear();
                                    Console.WriteLine("Medicamento Guardado con exito.");
                                    Console.WriteLine("Presione cualquier tecla para regresar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el Código del Medicamento que va a buscar para modificar.");
                                    respuesta2 = Console.ReadLine();
                                    medicamento = Medicamento.Buscar(respuesta2);
                                    if (medicamento == null)
                                    {
                                        Console.WriteLine("El Medicamento no existe.");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Medicamento.Imprimir(medicamento);
                                        string nuevoNombre = medicamento.nombre;
                                        Console.WriteLine("Elija la opcion que desee modificar");
                                        Console.WriteLine("1. Nombre");
                                        Console.WriteLine("................................");
                                        opcion2 = Console.ReadLine();
                                        switch (opcion2)
                                        {
                                            case "1":
                                                Console.WriteLine("................................");
                                                Console.WriteLine("Ingrese un nuevo nombre");
                                                respuesta2 = Console.ReadLine();
                                                if (Medicamento.Modificar(nuevoNombre, respuesta2))
                                                {
                                                    Console.WriteLine("Su nuevo nombre es : " + medicamento.nombre);
                                                }
                                                break;
                                        }
                                    }
                                    Console.Clear();
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el Código del medicamento que va a eliminar");
                                    respuesta2 = Console.ReadLine();
                                    medicamento = Medicamento.Buscar(respuesta2);
                                    if (medicamento == null)
                                    {
                                        Console.WriteLine("No existe ");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Medicamento.Eliminar(respuesta2);
                                    }
                                    Console.Clear();
                                    break;
                                case "4":
                                    Medicamento.Enlistar();
                                    Console.WriteLine("Presione cualquier tecla para regresar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "5":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el Código del medicamento que va a buscar");
                                    respuesta2 = Console.ReadLine();
                                    medicamento = Medicamento.Buscar(respuesta2);
                                    if (medicamento == null)
                                    {
                                        Console.WriteLine("El medicamento no existe");
                                        Console.WriteLine("................................");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Medicamento.Imprimir(medicamento);
                                        Console.WriteLine("................................");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    Console.Clear();

                                    break;
                                case "6":
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("................................");
                                    Console.WriteLine("No se ha selecionado ninguna opción.");
                                    Console.WriteLine("Presione cualquier tecla para regresar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        } while (opcion2 != "6");
                        break;
                    case "3":
                        string opcion3;
                        string codigo3, nombre3, apellido3, sexo3, direccion3, telefono3, correo3, respuesta3;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("................................");
                            Console.WriteLine("1. Ingresar Farmaceutico");
                            Console.WriteLine("2. Modificar Farmaceutico");
                            Console.WriteLine("3. Eliminar Farmaceutico");
                            Console.WriteLine("4. Imprimir Farmaceuticos");
                            Console.WriteLine("5. Buscar Farmaceutico");
                            Console.WriteLine("6. Regresar");
                            opcion3 = Console.ReadLine();
                            switch (opcion3)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese Código");
                                    codigo3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Nombre ");
                                    nombre3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Apellido");
                                    apellido3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Sexo");
                                    sexo3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Dirección");
                                    direccion3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Telefono");
                                    telefono3 = Console.ReadLine();
                                    Console.WriteLine("Ingrese Correo");
                                    correo3 = Console.ReadLine();
                                    Farmaceutico farmaceutico = new Farmaceutico(codigo3, nombre3, apellido3, sexo3, direccion3, telefono3, correo3);
                                    Farmaceutico.Ingresar(farmaceutico);
                                    Console.Clear();
                                    Console.WriteLine("Farmaceutico Guardado con exito.");
                                    Console.WriteLine("Presione cualquier tecla para regresar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el Código del Farmaceutico que va a buscar para modificar.");
                                    respuesta3 = Console.ReadLine();
                                    farmaceutico = Farmaceutico.Buscar(respuesta3);
                                    if (farmaceutico == null)
                                    {
                                        Console.WriteLine("El Farmaceutico no existe.");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Farmaceutico.Imprimir(farmaceutico);
                                        string nuevoNombre = farmaceutico.nombre;
                                        Console.WriteLine("Elija la opcion que desee modificar");
                                        Console.WriteLine("1. Nombre");
                                        opcion3 = Console.ReadLine();
                                        switch (opcion3)
                                        {
                                            case "1":
                                                Console.WriteLine("................................");
                                                Console.WriteLine("Ingrese un nuevo nombre");
                                                respuesta3 = Console.ReadLine();
                                                if (Farmaceutico.Modificar(nuevoNombre, respuesta3))
                                                {
                                                    Console.WriteLine("Su nuevo nombre es : " + farmaceutico.nombre);
                                                }
                                                break;
                                        }
                                    }
                                    Console.Clear();
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el Código del Farmaceutico que va a eliminar");
                                    respuesta3 = Console.ReadLine();
                                    farmaceutico = Farmaceutico.Buscar(respuesta3);
                                    if (farmaceutico == null)
                                    {
                                        Console.WriteLine("No existe ");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Farmaceutico.Eliminar(respuesta3);
                                    }
                                    Console.Clear();
                                    break;
                                case "4":
                                    Farmaceutico.Enlistar();
                                    Console.WriteLine("Presione cualquier tecla para regresar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "5":
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el Código del Farmaceutico que va a buscar");
                                    respuesta3 = Console.ReadLine();
                                    farmaceutico = Farmaceutico.Buscar(respuesta3);
                                    if (farmaceutico == null)
                                    {
                                        Console.WriteLine("El Farmaceutico no existe");
                                        Console.WriteLine("................................");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Farmaceutico.Imprimir(farmaceutico);
                                        Console.WriteLine("................................");
                                        Console.WriteLine("Presione cualquier tecla para regresar.");
                                        Console.ReadKey();
                                    }
                                    Console.Clear();

                                    break;
                                case "6":
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("................................");
                                    Console.WriteLine("No se ha selecionado ninguna opción.");
                                    Console.WriteLine("Presione cualquier tecla para regresar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        } while (opcion3 != "6");
                        break;
                    case "4":
                        Console.Clear();
                        string codigo4, nombre4, apellido4, direccion4, telefono4, respuesta4;
                        Console.WriteLine("Ingrese el Código del Farmaceutico");
                        respuesta4 = Console.ReadLine();
                        Farmaceutico farmaceutico1 = Farmaceutico.Buscar(respuesta4);
                        if (farmaceutico1 == null)
                        {
                            Console.WriteLine("El Farmaceutico no existe");
                            Console.WriteLine("................................");
                            Console.WriteLine("Presione cualquier tecla para regresar.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("................................");
                            Console.WriteLine("REALIZAR VENTA");
                            Console.WriteLine("................................");
                            Console.WriteLine("Ingrese Código Cliente");
                            codigo4 = Console.ReadLine();
                            Console.WriteLine("Ingrese Nombre Cliente ");
                            nombre4 = Console.ReadLine();
                            Console.WriteLine("Ingrese Apellido Cliente");
                            apellido4 = Console.ReadLine();
                            Console.WriteLine("Ingrese Dirección Cliente");
                            direccion4 = Console.ReadLine();
                            Console.WriteLine("Ingrese Telefono Cliente");
                            telefono4 = Console.ReadLine();
                            Cliente cliente = new Cliente(codigo4, nombre4, apellido4, direccion4, telefono4);
                            Cliente.Ingresar(cliente);
                            Console.Clear();
                            Console.WriteLine("................................");
                            Console.WriteLine("Ingresar Medicamento");
                            Console.WriteLine("Ingrese el Código del medicamento para ingresar");
                            respuesta4 = Console.ReadLine();
                            Medicamento medicamento1 = Medicamento.Buscar(respuesta4);
                            if (medicamento1 == null)
                            {
                                Console.WriteLine("El medicamento no existe");
                                Console.WriteLine("................................");
                                Console.WriteLine("Presione cualquier tecla para regresar.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("................................");
                                Console.WriteLine("FACTURA");
                                Console.WriteLine("ATENDIDO POR : " + farmaceutico1.nombre);
                                Console.WriteLine("................................");
                                Console.WriteLine("DATOS CLIENTE :");
                                Console.WriteLine("Nombre : "+ cliente.nombre + "/nApellido : " + cliente.apellido);
                                Console.WriteLine("Dirección :"+ cliente.direccion);
                                Console.WriteLine("................................");
                                Console.WriteLine("MEDICAMENTO : " + medicamento1.nombre);
                                Console.WriteLine("PRECIO FINAL : " + medicamento1.precio +" DÓLARES");
                                Console.WriteLine("................................");
                                Console.WriteLine("Presione cualquier tecla para regresar.");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case "0":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("................................");
                        Console.WriteLine("No se ha selecionado ninguna opción.");
                        Console.WriteLine("Presione cualquier tecla para regresar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != "0");


        }
    }
}
