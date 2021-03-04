using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tarea1MoisesNavarro
{
    class Program
    {
        public static void Main(string[] args)
        {
            Finca[] fincas = new Finca[10]; //Arreglo para registrar fincas 
            Dueno[] duenos = new Dueno[10]; //Arreglo para registrar duenos
            Empleado[] empleados = new Empleado[10]; //Areglo para registrar empleados
            Raza[] razas = new Raza[10]; //Arreglo para registrar razas
            Animal[] animales = new Animal[10]; //Arreglo para registrar animales
            //Contadores para realizar registros 
            int contadorF = 0, contadorD = 0, contadorE = 0, contadorR = 0, contadorA = 0;
            int op = 0;
            
            while (op!=7)
            {
                menu();
                Console.Write("=> ");
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.Write("Digite una opcion valida numero... ");
                    Thread.Sleep(1000);
                    //Console.ReadKey(true);
                }
                Console.Clear();
                string respuesta = "S";
                switch (op)
                {
                    case 1:                        
                        while (respuesta.ToUpper().Equals("S")) {
                            if (contadorF == 10)
                            {
                                Console.WriteLine("No hay suficiente memoria...");
                                Thread.Sleep(1000);
                                break;
                            }
                            else
                            {
                                fincas[contadorF] = registroFinca(fincas, contadorF);
                                contadorF++;
                                Console.Write("Desea agregar otra finca? [S/N] => ");
                                respuesta = Console.ReadLine();
                                Console.Clear();
                            }
                           
                        }
                        break;
                    case 2:
                        while (respuesta.ToUpper().Equals("S"))
                        {
                            if(contadorD == 10)
                            {
                                Console.WriteLine("No hay suficiente memoria...");
                                Thread.Sleep(1000);
                                break;
                            }
                            else
                            {
                                duenos[contadorD] = registrarDueno(fincas, contadorF, duenos, contadorD);
                                contadorD++;
                                Console.Write("Desea agregar otra dueño? [S/N] => ");
                                respuesta = Console.ReadLine();
                                Console.Clear();
                            }                            
                        }
                        break;

                    case 3:
                        while (respuesta.ToUpper().Equals("S"))
                        {
                            if (contadorE == 10)
                            {
                                Console.WriteLine("No hay suficiente memoria...");
                                Thread.Sleep(1000);
                                break;
                            }
                            else
                            {
                                empleados[contadorE] = registrarEmpleado(empleados, contadorE);
                                contadorE++;
                                Console.Write("Desea agregar otra dueño? [S/N] => ");
                                respuesta = Console.ReadLine();
                                Console.Clear();
                            }                            
                        }
                        break;

                    case 4:
                        while (respuesta.ToUpper().Equals("S"))
                        {
                            if (contadorR == 10)
                            {
                                Console.WriteLine("No hay suficiente memoria...");
                                Thread.Sleep(1000);
                                break;
                            }
                            else
                            {
                                razas[contadorR] = registrarRaza(razas, contadorR);
                                contadorR++;
                                Console.Write("Desea agregar otra dueño? [S/N] => ");
                                respuesta = Console.ReadLine();
                                Console.Clear();
                            }                         
                        }
                        break;
                    case 5:
                        while (respuesta.ToUpper().Equals("S"))
                        {
                            if (contadorA == 10)
                            {
                                Console.WriteLine("No hay suficiente memoria...");
                                Thread.Sleep(1000);
                                break;
                            }
                            else
                            {
                                animales[contadorA] = registrarAnimal(razas, fincas, contadorR, contadorF, animales, contadorA);
                                contadorA++;
                                Console.Write("Desea agregar otra dueño? [S/N] => ");
                                respuesta = Console.ReadLine();
                                Console.Clear();
                            }                            
                        }
                        break;
                    case 6:
                        int opR = 0;
                        while (opR != 6) { 
                        subMenu();
                        Console.Write("=>");
                        try { 
                        opR = int.Parse(Console.ReadLine());
                        }
                        catch (System.FormatException)
                        {
                            Console.Write("Digite una opcion valida... ");
                            Thread.Sleep(1000);
                            //Console.ReadKey(true);
                        }
                        registros(opR, fincas, contadorF, duenos, contadorD, empleados, contadorE,
                            razas, contadorR, animales, contadorA);
                        }
                        break;
                    default:
                        break;
                }

                Console.Clear();
            }

        }

        //Metodo para mostrar menu
        static void menu()
        {
            Console.WriteLine("\t\t.:Agroganadera Mi Finca:.\n");
            Console.WriteLine(
                "1. Registrar finca" +
                "\n2. Registrar dueño" +
                "\n3. Registrar empleado" +
                "\n4. Registrar raza de animales" +
                "\n5. Registrar animales" + 
                "\n6. Mostrar registros" +
                "\n7. Salir del sistema");
        }

        //Metodo para sub menu
        static void subMenu()
        {
            Console.WriteLine("\t\t.:Registros:.\n");
            Console.WriteLine(
                "1. Fincas registradas" + 
                "\n2. Dueños registrados" +
                "\n3. Empleados registrados" + 
                "\n4. Razas animales" +
                "\n5. Mostar animales" + 
                "\n6. Salir al menu pricipal");
        }

        static void registros(int op, Finca[] fincas, int contadorF, Dueno[] duenos, int contadorD, Empleado[] empleados, 
            int contadorE, Raza[] razas, int contadorR, Animal[] animales, int contadorA)
        {
            switch (op)
            {
                case 1:
                    mostarFincas(fincas, contadorF);
                    Console.Clear();
                    break;
                case 2:
                    mostarDuenos(duenos, contadorD);
                    Console.Clear();
                    break;
                case 3:
                    mostrarEmpleados(empleados, contadorE);
                    Console.Clear();
                    break;
                case 4:
                    mostrarRazas(razas, contadorR);
                    Console.Clear();
                    break;
                case 5:
                    mostrarAnimales(animales, contadorA);
                    Console.Clear();
                    break;
                    
                default: Console.Clear(); break;
            }
        }

        //Funccion para realizar registro
        static Finca registroFinca(Finca[] fincas, int contadorF)
        {
            int numFinca = 0, size = 0, tel = 0, indice = 0;
            string nombre = "", direccion = "";
            bool valido = true;

            while (valido) {
                try
                {
                    Console.WriteLine(".:Registrando finca:.");

                    do
                    {
                        try
                        {
                            Console.Write("\nDigite el numero de finca: ");
                            numFinca = int.Parse(Console.ReadLine());
                            indice = exite(fincas, contadorF, numFinca);

                            if (indice >= 0)
                            {
                                Console.WriteLine("\nLa finca ya se encuentra registada...");
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine(".:Registrando finca:.");
                            }
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\nDigite valores validos...");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine(".:Registrando finca:.");
                        }
                    } while (indice >= 0);

                    Console.Write("Digite el nombre de la finca: ");
                    nombre = Console.ReadLine();
                    Console.Write("Digite el tamano de la finca: ");
                    size = int.Parse(Console.ReadLine());
                    Console.Write("Digite la direccion: ");
                    direccion = Console.ReadLine();
                    Console.Write("Digite el numero de telefono: ");
                    tel = int.Parse(Console.ReadLine());
                    valido = false;
               
                } catch (System.FormatException)
                {
                    valido = true;
                    Console.WriteLine("\nDigite valores validos...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }

            Finca finca = new Finca(numFinca, nombre, size, direccion, tel);
            return finca;
        }

        //Funcion para registrar dueño
        static Dueno registrarDueno(Finca[] fincas, int contadorF, Dueno[] duenos, int contadorD)
        {
            Dueno dueno;            
            int indice = 0, id = 0, cel = 0;
            string nombre = "", primerApe = "", segundoApe = "", correo = "";
            bool valido = true;

            while (valido) {
                try {
                    Console.WriteLine("\t\t.:Registrar dueño:.\n");
                    do
                    {
                        try
                        {
                            Console.Write("Digite el id: ");
                            id = int.Parse(Console.ReadLine());
                            indice = exite(fincas, contadorD, id);

                            if (indice >= 0)
                            {
                                Console.WriteLine("\nEl dueño ya se encuentra registado...");
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine(".:Registrando dueño:.\n");
                            }
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\nDigite valores validos...");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("\t\t.:Registrando dueño:.\n");
                        }
                    } while (indice >= 0);

                    Console.Write("Digite el nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Digite el primer apellido: ");
                    primerApe = Console.ReadLine();
                    Console.Write("Digite el segundo apellido: ");
                    segundoApe = Console.ReadLine();
                    Console.Write("Digite el correo: ");
                    correo = Console.ReadLine();
                    Console.Write("Digite el numero de celular: ");
                    cel = int.Parse(Console.ReadLine());

                    valido = false;
                }
                catch (System.FormatException)
                {
                    valido = true;
                    Console.WriteLine("\nDigite valores validos...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }

            do
            {
                try { 
                Console.Write("Digite el numero de finca que le pertenece: ");
                int numFinca = int.Parse(Console.ReadLine());
                indice = exite(fincas, contadorF, numFinca);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\nDigite valores validos...\n");
                    Thread.Sleep(1000);
                }
            } while (indice.Equals(-1));

            dueno = new Dueno(id, nombre, primerApe, segundoApe, correo, cel, fincas[0]);

            return dueno;
        }

        //Funcion para registrar empleado
        static public Empleado registrarEmpleado(Empleado[] empleados, int contador)
        {
            int id = 0, indice = 0;
            double salario = 0;
            string nombre = "", primerApe = "", segundoApe = "";
            bool valido= true;

            while (valido) {
                Console.WriteLine("\t\t.:Registrar empleado:.\n");

                try {
                    do
                    {
                        try
                        {
                            Console.Write("Digite el id: ");
                            id = int.Parse(Console.ReadLine());
                            indice = exiteE(empleados, contador, id);

                            if (indice >= 0)
                            {
                                Console.WriteLine("\nEl empleado ya se encuentra registado...");
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("\t\t.:Registrando empleado:.\n");
                            }
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\nDigite valores validos...");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("\t\t.:Registrando empleado:.\n");
                        }
                    } while (indice >= 0);
                    Console.Write("Digite el nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Digite el primer apellido: ");
                    primerApe = Console.ReadLine();
                    Console.Write("Digite el segundo apellido: ");
                    segundoApe = Console.ReadLine();
                    Console.Write("Digite el salario: ");
                    salario = double.Parse(Console.ReadLine());

                    valido = false;

                }
                catch (System.FormatException)
                {
                    valido = true;
                    Console.WriteLine("\nDigite valores validos...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }

            Empleado empleado = new Empleado(id, nombre, primerApe, segundoApe, salario);

            return empleado;
        }

        //funcion para registrar raza
        static public Raza registrarRaza(Raza[] razas, int contador)
        {
            string codigo = "", descripcion = "";
            int indice = 0;

            do
            {
                Console.WriteLine("\t\t.:Registrando raza:.\n");

                Console.Write("Digite el codigo de la raza: ");
                codigo = Console.ReadLine();
                Console.Write("Digite la descripcion de la raza: ");
                descripcion = Console.ReadLine();
                indice = exiteR(razas, contador, codigo);

                if (indice >= 0)
                {
                Console.WriteLine("\nLa raza ya se encuentra registada...");
                Thread.Sleep(1000);
                Console.Clear();
                }
            } while (indice >= 0);

            Raza raza = new Raza(codigo, descripcion);

            return raza;
        }

        //Funcion para registrar animales
        static public Animal registrarAnimal(Raza[] razas, Finca[] fincas ,int contadorR, int contadorF, Animal[] animales,
            int contadorA)
        {
            int id = 0, op = 0, indiceR = 0, indiceF = 0, indice = 0;
            string nombre = "", madre = "", padre = "", sexo = "";
            bool valido = true;
             
            while (valido) {
                Console.WriteLine("\t\t.:Registran animales:.\n");
                try {
                    do
                    {
                        try
                        {
                            Console.Write("Digite el id: ");
                            id = int.Parse(Console.ReadLine());
                            indice = exiteA(animales, contadorA, id);

                            if (indice >= 0)
                            {
                                Console.WriteLine("\nEl animal ya se encuentra registado...");
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("\t\t.:Registrando Animal:.\n");
                            }
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\nDigite valores validos...");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("\t\t.:Registrando Animal:.\n");
                        }
                    } while (indice >= 0);
                    Console.Write("Digite el nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Digite el sexo [1- Hembra / 2- Macho]: ");
                    op = int.Parse(Console.ReadLine());
                    if(op == 1)
                    {
                        sexo = "Hembra"; 
                    }
                    else if (op == 2){
                        sexo = "Macho";
                    }
                    Console.Write("Digite el nombre de la madre: ");
                    madre = Console.ReadLine();
                    Console.Write("Digite el nombre del padre: ");
                    padre = Console.ReadLine();
                    do
                    {
                        Console.Write("Digite el codigo de la Raza: ");
                        string codigo = Console.ReadLine();
                        indiceR = exiteR(razas, contadorR, codigo);
                    } while (indiceR.Equals(-1));

                    do
                    {
                        try
                        {
                            Console.Write("Digite el numero de finca que le pertenece: ");
                            int numFinca = int.Parse(Console.ReadLine());
                            indiceF = exite(fincas, contadorF, numFinca);
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\nDigite valores validos...");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    } while (indiceF.Equals(-1));

                    valido = false;
                }
                catch(System.FormatException)
                {
                    Console.WriteLine("\nDigite valores validos...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }

            Animal animal = new Animal(id, nombre, fincas[indiceF], razas[indiceR], sexo, madre, padre);
            return animal;
        }

        //Funcion para verificar raza existente
        static public int exiteR(Raza[] razas, int contador, string codigo)
        {
            for (int i = 0; i < contador; i++)
            {
                if (razas[i].Codigo.Equals(codigo))
                {
                    return i;
                }
            }
            return -1;
        }


        //Funcion para verificar animal existente
        static public int exiteA(Animal[] animales, int contador, int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (animales[i].Id.Equals(id))
                {
                    return i;
                }
            }

            return -1;
        }

        //Funcion para verificar empleado existente
        static public int exiteE(Empleado[] empleados, int contador, int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (empleados[i].Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        //Funcion para verificar finca existente
        static public int exite(Finca[] fincas, int contador, int numFinca)
        {
            for (int i = 0; i < contador; i++)
            {
                if (fincas[i].NumFinca.Equals(numFinca))
                {
                    return i;
                }
            }
            return -1;
        }

        //Metodo para mostrar fincas
        static void mostarFincas(Finca[] finca, int contador)
        {
            Console.Clear();
            Console.WriteLine("\t\t.:Registro de fincas:.");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("\n******************************************************\n");
                Console.WriteLine(finca[i].ToString());
            }
            Console.WriteLine("\nPulse cualquier tecla para continuar...");
            Console.ReadKey(true);
        }

        //Metodo para mostrar dueños
        static void mostarDuenos(Dueno[] duenos, int contador)
        {
            Console.Clear();
            Console.WriteLine("\t\t.:Registro de dueños:.");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("\n******************************************************\n");
                Console.WriteLine(duenos[i].ToString());
            }
            Console.WriteLine("\nPulse cualquier tecla para continuar...");
            Console.ReadKey(true);
        }

        //Metodo para mostar empleados
        static void mostrarEmpleados(Empleado[] empleados, int contador)
        {
            Console.Clear();
            Console.WriteLine("\t\t.:Registro de Empleados:.");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("\n******************************************************\n");
                Console.WriteLine(empleados[i].ToString());
            }
            Console.WriteLine("\nPulse cualquier tecla para continuar...");
            Console.ReadKey(true);
        }


        //Metodo para mostar razas
        static void mostrarRazas(Raza[] razas, int contador)
        {
            Console.Clear();
            Console.WriteLine("\t\t.:Registro de razas:.");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("\n******************************************************\n");
                Console.WriteLine(razas[i].ToString());
            }
            Console.WriteLine("\nPulse cualquier tecla para continuar...");
            Console.ReadKey(true);
        }

        //Metodo para mostar razas
        static void mostrarAnimales(Animal[] animales, int contador)
        {
            Console.Clear();
            Console.WriteLine("\t\t.:Registro de Animales:.");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("\n******************************************************\n");
                Console.WriteLine(animales[i].ToString());
            }
            Console.WriteLine("\nPulse cualquier tecla para continuar...");
            Console.ReadKey(true);
        }
    }
}
