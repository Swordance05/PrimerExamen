using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GlobalMachine
{
    class Program
    {
        static int opcion;
        static int leer;
        static int acumulador = 0;




        struct datos
        {

            public int id;
            public String nombre;
            public String tipo;
            public String fechavencimiento;
            public String nombreproveedor;
            public int posicion;
            public int precio;
        }

        static datos[] matriz;



        static void Main(string[] args)
        {




            Console.WriteLine("Cuantos productos desea registrar");
            leer = int.Parse(Console.ReadLine());

            matriz = new datos[leer];



            do
            {

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("               Global machines              ");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1° Ingreso de productos");
                Console.WriteLine("2° Modificación de productos");
                Console.WriteLine("3° Borrado de productos");
                Console.WriteLine("4° Búsqueda de productos");
                Console.WriteLine("5° Listado de productos");
                Console.WriteLine("6° Venta productos");
                Console.WriteLine("7° Salir ");
                Console.WriteLine("--------------------------------------------");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {

                    case 1:
                        IngresoDeProductos();

                        break;

                    case 2:
                        ModificacionDeProductos();

                        break;

                    case 3:
                        BorradoDeProducto();

                        break;

                    case 4:
                        BusquedaDeProductos();

                        break;

                    case 5:
                        ListadoDeProductos();

                        break;

                    case 6:
                        Ventas();

                        break;

                }

            } while (opcion < 6);


        }


        public static void IngresoDeProductos()
        {



            do
            {

                Console.WriteLine("Ingrese el ID");
                matriz[acumulador].id = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre");
                matriz[acumulador].nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el tipo del producto");
                matriz[acumulador].tipo = Console.ReadLine();

                Console.WriteLine("Ingrese la fecha de vencimiento");
                matriz[acumulador].fechavencimiento = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre del proveedor");
                matriz[acumulador].nombreproveedor = Console.ReadLine();

                Console.WriteLine("Ingrese el edad");
                matriz[acumulador].posicion = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el precio de producto");
                matriz[acumulador].posicion = int.Parse(Console.ReadLine());

                Console.WriteLine(matriz[acumulador].id + " " + matriz[acumulador].nombre + " " + matriz[acumulador].tipo + " " + matriz[acumulador].fechavencimiento + " " + matriz[acumulador].nombreproveedor + " " + matriz[acumulador].posicion + " " + matriz[acumulador].precio);

                acumulador++;




            } while (acumulador < leer);
        }


        public static void ModificacionDeProductos()
        {

            int respuesta = 0;
            int leer1 = 0;


            Console.WriteLine("Ingrese el ID que desea modificar");
            leer1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < leer; i++)
            {

                if (leer1 == matriz[i].id)
                {

                    Console.WriteLine(matriz[i].id + " " + matriz[i].nombre + " " + matriz[i].tipo + " " + matriz[i].fechavencimiento + " " + matriz[acumulador].nombreproveedor + " " + matriz[acumulador].posicion);
                


                    Console.WriteLine("Que dato desea modificar");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("1° Nombre del producto");
                    Console.WriteLine("2° Tipo del producto");
                    Console.WriteLine("3° Fecha de vencimiento");
                    Console.WriteLine("4° Nombre proveedor");
                    Console.WriteLine("5° Posición del articulo");
                    Console.WriteLine("6° Precio");
                    
                    
                    respuesta = int.Parse(Console.ReadLine());



                    switch (respuesta)
                    {

                        case 1:

                            Console.WriteLine("Ingrese el nombre");
                            matriz[i].nombre = Console.ReadLine();
                            break;

                        case 2:

                            Console.WriteLine("Ingrese el tipo del producto");
                            matriz[i].tipo = Console.ReadLine();
                            break;

                        case 3:

                            Console.WriteLine("Ingrese la fecha de vencimiento");
                            matriz[i].fechavencimiento = Console.ReadLine();
                            break;
                        
                        case 4:

                            Console.WriteLine("Ingrese el nombre del proveedor");
                            matriz[i].nombreproveedor = Console.ReadLine();
                            break;
                        
                        case 5:

                            Console.WriteLine("Ingrese la posicion del producto");
                            matriz[i].posicion = int.Parse(Console.ReadLine());
                            break;

                        case 6:

                            Console.WriteLine("Precio del producto nuevo");
                            matriz[i].precio = int.Parse(Console.ReadLine());
                            break;


                    }



                }

                else
                {

                    Console.WriteLine("No se encontro el ID del estudiante");


                }
            }
        }


        public static void BorradoDeProducto()
        {

            int leer2 = 0;

            

            Console.WriteLine("Ingrese el ID del producto que desea eliminar");
            leer2 = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < leer; i++)
            {

                if (leer2 == matriz[i].id)
                {

                    matriz[i].id = 0;
                    matriz[i].nombre = " ";
                    matriz[i].tipo = " ";
                    matriz[i].fechavencimiento = " ";
                    matriz[i].nombreproveedor = " ";
                    matriz[i].posicion = 0;
                    matriz[i].precio = 0;

                }

                else
                {

                    Console.WriteLine("No se encontro el ID del producto");

                }

            }


        }

        public static void BusquedaDeProductos()
        {

            int leer3 = 0;

            Console.WriteLine("Ingrese el ID del producto que desea buscar");
            leer3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < leer3; i++)
            {

                if (leer3 == matriz[i].id)
                {

                    Console.WriteLine("ID: " + matriz[i].id);
                    Console.WriteLine("NOMBRE DEL PRODUCTO: " + matriz[i].nombre);
                    Console.WriteLine("TIPO: " + matriz[i].tipo);
                    Console.WriteLine("FECHA VENCIMIENTO: " + matriz[i].fechavencimiento);
                    Console.WriteLine("NOMBRE PROVEEDOR: " + matriz[i].nombreproveedor);
                    Console.WriteLine("TIPO: " + matriz[i].posicion);
                    Console.WriteLine("PRECIO DEL PRODUCTO: " + matriz[i].precio);
                    


                }

                else
                {

                    Console.WriteLine("No se encontro el ID del producto");


                }

            }


        }

        public static void ListadoDeProductos()
        {

            Console.WriteLine("============================================");
            Console.WriteLine("             Global Machines                ");
            Console.WriteLine("============================================");
            Console.WriteLine("           Listado de productos             ");
            Console.WriteLine("============================================");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("REG " + "Codigo " + "Nombre " + "tipo " + "fecha de vencimiento " + "Nombre del proveedor" + "Posicion" + "Precio");

            for (int i = 0; i < leer; i++)
            {

                Console.WriteLine(i + 1 + "  " + matriz[i].id + "  " + matriz[i].nombre + "  " + matriz[i].tipo + "  " + matriz[i].fechavencimiento + "  " + matriz[i].nombreproveedor + "  " + matriz[i].posicion+ "  " + matriz[i].precio);

                Console.ReadKey();


            }
            Console.WriteLine("Fin del listado");
            Console.Clear();
        }

        public static void InformeDeProductos()
        {

            
            
            String tipo = " ";
            int posicion = 0;

            Console.WriteLine("===========================================================");
            Console.WriteLine("                     Global Machines                  ");
            Console.WriteLine("===========================================================");
            Console.WriteLine("                  Informe de inventario              ");
            Console.WriteLine("===========================================================");
            Console.WriteLine("  Clasificación                ||                Cantidad");
            Console.WriteLine("-----------------------------------------------------------");

            for (int y = 0; y < leer; y++)
            {

                tipo = matriz[y].tipo;

                posicion = matriz[y].posicion;

                Console.WriteLine("Tipo      " + tipo);
                Console.WriteLine(".....................      ");
                Console.WriteLine("Posicion      " + posicion);
                Console.WriteLine(".....................      ");

                Console.WriteLine("===========================================================");

                Console.WriteLine("Fin de Listado");

                Console.ReadKey();

                Console.Clear();
            }


        }

        public static void Ventas() {

        String nombre = " ";
        String telefono = " ";
        int cantidad = 0;
        double precio = 0;
        double descuento = 1;
        double varlordes = 0;
        double iva, total = 0;
        double neto = 0;
        double recibir = 0;
        double cambio = 0;
        double totalorden = 0;
        double descuentototal = 0;
        Boolean terminar = false;
        char caracter = ' ';
        int numero = 0;
        double subtotal = 0;
        int[,] compra = new int[150, 2];
        int contador = 0;
        int[] Precios = new int[10] { 550, 2500, 300, 500, 450, 100, 700, 370, 540, 600 };
        string[,] Productos = new string[10, 2]{{"1-  Pan bimbo ","- Reposteria"},{"2-  Galletas chikys     ","- Galletas"},{"3-  Coca cola                 ","- Gaseosas"},{"4-  Jabón líquido                        ","- Jabones"},{"5-  Pañuelos     ","- reposteria"},
        {"6-  Meneitos         ","- Frituras"},{"7-  Corn Flakes            ","- Cereales"},{"8-  Pilsen                         ","- Cerveza"},{"9-  Morenitos                         ","- Confites"},{"10- Tropical           ","- Naturales"}};

         
        
            
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            
            Console.WriteLine("Ingrese numero de telefono del cliente");
            numero = int.Parse(Console.ReadLine());
        
            while (!terminar)
            {

                Console.WriteLine("-----------------------------------------------------------");

                Console.WriteLine("Sistema de Productos Global Machines");

                Console.WriteLine("-----------------------------------------------------------");

               for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine(" ");

                    for (int x = 0; x < 2; x++)
                    {

                        Console.Write(Productos[i, x]);



                    }


       


                }


                Console.WriteLine(" ");

                Console.WriteLine("-----------------------------------------------------------");

                Console.WriteLine("Ingrese el numero del Producto que desea comprar");

                numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de Producto que desea comprar");

                cantidad = int.Parse(Console.ReadLine());

                compra[contador, 0] = numero;
                compra[contador, 1] = cantidad;

                contador++;

                Console.WriteLine("¿Desea comprar otro Producto?(S)(N)");

                caracter = char.Parse(Console.ReadLine());

                if (caracter == 'N' || caracter == 'n')
                {

                    terminar = true;

                }
                else
                {

                    terminar = false;

                }

            }

            Console.WriteLine("resultado");

           

            for (int y = 0; y < contador; y++)
            {

                Console.WriteLine(" ");
                subtotal = Precios[compra[y, 0] - 1] * compra[y, 1];
                totalorden = totalorden + subtotal;
                Console.WriteLine("Total orden ¢" + totalorden);



                for (int t = 0; t < 2; t++)
                {

                   
                    Console.Write(compra[y, t]);
                    Console.Write(" -- ");



                }
            }

            Console.WriteLine(" ");

            Console.WriteLine("====================================================================");
            Console.WriteLine("*-*                   Global Machines                *-*   ");
            Console.WriteLine("====================================================================");
            Console.WriteLine("Factura proformar");
            Console.WriteLine("Cliente:" + nombre);
            Console.WriteLine("Telefono:" + telefono);

            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Item                                             Ctd    Precio    SubTotal      ");

            Console.WriteLine(" ");

            for (int j = 0; j < contador; j++)
            {

                subtotal = Precios[compra[j, 0] - 1] * compra[j, 1];

                Console.WriteLine(Productos[compra[j, 0] - 1, 0] + "      " + compra[j, 1] + "      ¢" + Precios[compra[j, 0] - 1] + "      ¢" + subtotal);

                Console.WriteLine("   ");

                

                switch (Productos[compra[j, 0], 1])
                {

                    case "- Gaseosas":
                        
                        descuento = Precios[compra[j, 0] - 1] * 0.5;
                        

                        break;

                    case "- Frituras":
                       
                        descuento = Precios[compra[j, 0] - 1] * 0.15;
                        
                        break;

                    case "- Reposteria":
                        
                        descuento = Precios[compra[j, 0] - 1] * 0.20;
                       
                        break;

                    case "- Confites":
                        
                        descuento = Precios[compra[j, 0] - 1] * 0.10;
                        
                        break;

                    default:
                        
                        descuento = Precios[compra[j, 0] - 1] * 0.25;
                        
                        break;


                }

                descuento = descuento * compra[j, 1];

                descuentototal = descuentototal + descuento;



            }

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Total orden: " + totalorden + "¢");
            Console.WriteLine("Descuento: " + descuentototal + "¢");
            Console.WriteLine("Impuesto de venta : 13%");
            iva = totalorden * 0.13;
            Console.WriteLine("Impuesto total :" + iva);
            neto = totalorden - descuentototal + iva;
            Console.WriteLine("Precio neto :" + neto);

            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine(" ");

            Console.Write("Monto recibido : ¢");
            recibir = Double.Parse(Console.ReadLine());
            

            cambio = recibir - neto;

            Console.WriteLine("Monto cambio : ¢" + cambio);

            Console.WriteLine("====================================================================");

            Console.WriteLine("Gracias por su compra, que vuelva pronto!!!!!");

            Console.ReadKey();



        }
    }


        
        
        }

    


