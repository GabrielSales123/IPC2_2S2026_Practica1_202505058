public class Program
{
    public static bool isRunning = true;

    public static void Main(string[] args)
    {
        Mascota? tempMascota;
         
        
        ListaMascotas listaMascotas = new ListaMascotas();
        listaMascotas.agregarMascota(new Perro("Firulais", 45, 3, "Macho", "Juan Perez", "1", false, "Labrador", "Grande"));
        listaMascotas.agregarMascota(new Perro("Rex", 15, 4, "Macho", "Pedro Lopez", "2", false, "Boxer", "Grande"));
        listaMascotas.agregarMascota(new Gato("Luna", 5, 2, "Hembra", "Ana Martinez", "3", true, true, "Siames"));
        //listaMascotas.agregarMascota(new Gato("Tom", 15, 3, "Macho", "Luis Perez", "4", false, false, "Persa"));
        //listaMascotas.agregarMascota(new Ave("Kiwi", 2, 1, "Hembra", "Maria Gomez", "5", false, 22, true));
        //listaMascotas.agregarMascota(new Ave("Paco", 15, 2, "Macho", "Carlos Diaz", "6", true, 28, false));
        //listaMascotas.agregarMascota(new Tortuga("Shell", 12, 5, "Hembra", "Laura Torres", "7", false, "Duro", true));
        //listaMascotas.agregarMascota(new Tortuga("Nemo", 15, 4, "Macho", "Daniel Vega", "8", true, "Blando", false));

        while (isRunning)
        {
            Console.WriteLine("============Veterinaria============");
            Console.WriteLine("Bienvenido a la Veterinaria");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Registrar mascota");
            Console.WriteLine("2. Consultar mascota");
            Console.WriteLine("3. Cambiar estado de paciente");
            Console.WriteLine("4. Calcular dosis de medicamento");
            Console.WriteLine("5. Mostrar información de las mascotas");
            Console.WriteLine("6. Salir");
            Console.WriteLine("====================================");

            switch (Console.ReadLine())
            {
                case "1":
                //==================================================================
                    //Configuraciones Generales
                    //Nombre------------------------------------------------
                    Console.WriteLine("Ingrese el nombre de la mascota: ");
                    string nombre = Console.ReadLine();
                    //Peso-------------------------------------------------
                    Console.WriteLine("Ingrese el peso de la mascota en Kg: ");
                    int peso = Convert.ToInt32(Console.ReadLine());
                    //Edad-------------------------------------------------
                    Console.WriteLine("Ingrese la edad de la mascota: ");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    //Sexo -------------------------------------------------
                    Console.WriteLine("Ingrese el sexo de la mascota: ");
                    string sexo = Console.ReadLine();
                    //Propietario-------------------------------------------
                    Console.WriteLine("Ingrese el nombre del propietario: ");
                    string propietario = Console.ReadLine();
                    //Codigo-------------------------------------------------
                    string codigo = (listaMascotas.contMascotas() + 1).ToString();
                    //Estado------------------------------------------------
                    Console.WriteLine("Ingrese si la mascota está enferma (Y/N): ");
                    string inputEnfermo = Console.ReadLine();
                    bool enfermo = inputEnfermo.ToUpper() == "Y";
                    //Tipo de mascota --------------------------------------
                    Console.WriteLine("Ingrese el tipo de mascota (Perro/Gato/Ave/Tortuga): ");
                    string tipoMascota = Console.ReadLine();
                    //Logica -----------------------------
                    if(tipoMascota == "Perro"){
                        //Raza de perro 
                        Console.WriteLine("Ingrese la raza del perro: ");
                        string raza = Console.ReadLine();
                        //Tamaño de perro
                        Console.WriteLine("Ingrese el tamaño del perro: ");
                        string tamaño = Console.ReadLine();
                        //Enviar datos al nodo
                        listaMascotas.agregarMascota(new Perro(nombre, peso, edad, sexo, propietario, codigo, enfermo, raza, tamaño));
                    } else if(tipoMascota == "Gato"){
                        //Raza Gato
                        Console.WriteLine("Ingrese la raza del gato: ");
                        string raza = Console.ReadLine();
                        //Estado Esteril
                        Console.WriteLine("Está esterilizado?(Y/N): ");
                        string inputEsteril = Console.ReadLine();
                        bool esteril = inputEsteril.ToUpper() == "Y";
                        //Enviar datos al nodo
                        listaMascotas.agregarMascota(new Gato(nombre, peso, edad, sexo, propietario, codigo, enfermo, esteril, raza));
                    } else if (tipoMascota == "Ave")
                    {
                        //Envergadura del ave
                        Console.WriteLine("Ingrese el tamaño de la envergadura del ave: ");
                        int envergadura = Convert.ToInt32(Console.ReadLine()); 
                        //Puede volar
                        Console.WriteLine("Indique si el ave puede volar(Y/N): ");
                        string inputVolar = Console.ReadLine();
                        bool volar = inputVolar.ToUpper() == "Y";
                        listaMascotas.agregarMascota(new Ave(nombre, peso, edad, sexo, propietario, codigo, enfermo, envergadura, volar));
                    }else if (tipoMascota == "Tortuga")
                    {
                        //Caparazón
                        Console.WriteLine("Ingrese el tipo de caparazón");
                        String caparazon = Console.ReadLine();
                        //Acuatica
                        Console.WriteLine("Indique si la tortuga es acuatica(Y/N)");
                        string inputAcuatica = Console.ReadLine();
                        bool isAcuatica = inputAcuatica.ToUpper() == "Y";
                        listaMascotas.agregarMascota(new Tortuga(nombre, peso, edad, sexo, propietario, codigo, enfermo, caparazon, isAcuatica)); 
                    }else {
                        Console.WriteLine("Tipo de mascota no válido.");
                    }
                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                    //===================================================================
                case "2":
                    Console.WriteLine("Ingrese el código de la mascota a consultar: ");
                    listaMascotas.buscar(Console.ReadLine());
                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "3":
                    Console.WriteLine("Ingrese el código de la mascota a cambiar estado: ");
                    tempMascota = listaMascotas.consultarMascota(Console.ReadLine());
                    if (tempMascota != null)
                    {
                        Console.WriteLine("Mascota seleccionada: "+tempMascota.GetNombre());
                        tempMascota.SetEnfermo(!tempMascota.GetEnfermo());
                        Console.WriteLine("Estado cambiado. Enfermo: " + tempMascota.GetEnfermo());
                    }
                    else
                    {
                        Console.WriteLine("Mascota no encontrada.");
                    }
                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "4":
                    Console.WriteLine("Ingrese el codigo de la mascota a consultar");
                    tempMascota= listaMascotas.consultarMascota(Console.ReadLine());
                    if(tempMascota != null)
                    {
                        Console.WriteLine("Nombre de la mascota: "+ tempMascota.GetNombre());
                        Console.WriteLine("Peso: "+tempMascota.GetPeso()+"Kg");
                        Console.WriteLine("La dosis necesaria es de: "+tempMascota.CalcularDosis()+"ml");
                        
                    }
                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "5":
                    Console.Clear();
                    listaMascotas.mostrarMascotas();
                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                break; 
                case "6":
                    Console.Clear();        
                    isRunning = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}