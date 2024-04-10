using System;

namespace metodologia_de_programacion_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            
            /* 
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

            llenar(pila);
            llenar(cola);

            Console.WriteLine("Información de la Pila:");
            informar(pila);

            Console.WriteLine("\nInformación de la Cola:");
            informar(cola);

            Console.WriteLine("\nInformación de la Colección Múltiple:");
            informar(multiple);
            
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

            llenarPersonas(pila);
            llenarPersonas(cola);

            Console.WriteLine("Información de la Colección Múltiple de Personas:");
            informarPersonas(multiple);
             */

            llenarAlumnos(pila);
            llenarAlumnos(cola);

            Console.WriteLine("Información de la Colección Múltiple de Alumnos:");

            informar(multiple);
            
            Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
        }
        

        static void llenar(Coleccionable coleccion)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                int valorAleatorio = random.Next(1, 101);
                Comparable comparable = new Numero(valorAleatorio);
                coleccion.agregar(comparable);
            }
        }

        static void informar(Coleccionable coleccion)
        {
            Console.WriteLine("Cantidad de elementos en la colección: " + coleccion.cuantos());
            Console.WriteLine("Elemento mínimo de la colección: " + coleccion.minimo());
            Console.WriteLine("Elemento máximo de la colección: " + coleccion.maximo());

            if (coleccion.contiene(comparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }
        }
        public static void llenarPersonas(Coleccionable coleccion)
        {
            Random random = new Random();
            string[] nombres = {"Juan", "Maria", "Carlos", "Laura", "Pedro", "Ana", "Luis", "Elena", "Diego", "Sofia"};
            for (int i = 0; i < 20; i++)
            {
                int indiceNombre = random.Next(nombres.Length);
                string nombreAleatorio = nombres[indiceNombre];
                int dniAleatorio = random.Next(10000000, 99999999); // Genera un DNI aleatorio de 8 dígitos
                Comparable comparable = new Persona(nombreAleatorio, dniAleatorio);
                coleccion.agregar(comparable);
            }
        }
        static void informarPersonas(Coleccionable coleccion)
        {
            Console.WriteLine("Cantidad de elementos en la colección: " + coleccion.cuantos());
            Console.WriteLine("Elemento mínimo de la colección: " + ((Persona)coleccion.minimo()).getNombre() + " - DNI: " + ((Persona)coleccion.minimo()).getDNI());
            Console.WriteLine("Elemento máximo de la colección: " + ((Persona)coleccion.maximo()).getNombre() + " - DNI: " + ((Persona)coleccion.maximo()).getDNI());

            Console.WriteLine("Ingrese un DNI para verificar si está en la colección:");
            int dniLeido = int.Parse(Console.ReadLine());
            Comparable comparable = new Persona("", dniLeido);

            if (coleccion.contiene(comparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }
        }
        static void llenarAlumnos(Coleccionable coleccion)
        {
            Random random = new Random();
            string[] nombres = {"Juan", "Maria", "Carlos", "Laura", "Pedro", "Ana", "Luis", "Elena", "Diego", "Sofia"};
            for (int i = 0; i < 20; i++)
            {
                int indiceNombre = random.Next(nombres.Length);
                string nombreAleatorio = nombres[indiceNombre];
                int dniAleatorio = random.Next(10000000, 99999999); // Genera un DNI aleatorio de 8 dígitos
                int legajoAleatorio = random.Next(1000, 9999); // Genera un legajo aleatorio de 4 dígitos
                double promedioAleatorio = random.NextDouble() * 10; // Genera un promedio aleatorio entre 0 y 10
                Comparable comparable = new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio);
                coleccion.agregar(comparable);
            }
        }
        static void informarAlumnos(Coleccionable coleccion)
        {
            Console.WriteLine("Cantidad de elementos en la colección: " + coleccion.cuantos());
            Console.WriteLine("Elemento mínimo de la colección: " + ((Alumno)coleccion.minimo()).getNombre() + " - DNI: " + ((Alumno)coleccion.minimo()).getDNI());
            Console.WriteLine("Elemento máximo de la colección: " + ((Alumno)coleccion.maximo()).getNombre() + " - DNI: " + ((Alumno)coleccion.maximo()).getDNI());

            Console.WriteLine("Ingrese un DNI para verificar si está en la colección:");
            int dniLeido = int.Parse(Console.ReadLine());
            Comparable comparable = new Alumno("", dniLeido, 0, 0);

            if (coleccion.contiene(comparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }
        }
    }
}


