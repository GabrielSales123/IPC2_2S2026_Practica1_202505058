public class Program
{
    public static bool isRunning = true;

    public static void Main(string[] args)
    {
        Mascota? tempMascota;
        double tempDosis; 
        double dosis = 30.0; 
        ListaMascotas listaMascotas = new ListaMascotas();
        listaMascotas.agregarMascota(new Perro("Firulais", 45, 3, "Mencho", "Juan Perez", "1", false, "Labrador", "Grande"));
        listaMascotas.agregarMascota(new Perro("Firulais2", 50, 3, "Mencho", "Juan Perez", "2", false, "Labrador", "Grande"));
        listaMascotas.agregarMascota(new Perro("Firulais3", 55, 3, "Mencho", "Juan Perez", "3", false, "Labrador", "Grande"));
        listaMascotas.mostrarMascotas();

        while (isRunning)
        {
            Console.WriteLine("============Veterinaria============");
            Console.WriteLine("Bienvenido a la Veterinaria");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Registrar mascota");
            Console.WriteLine("2. Consultar mascota");
            Console.WriteLine("3. Cambiar estado de paciente");
            Console.WriteLine("4. Calcular dosis de medicamento");
            Console.WriteLine("5. Mostrar información de mascota");
            Console.WriteLine("6. Salir");
            Console.WriteLine("====================================");

            switch (Console.ReadLine())
            {
                case "1":
                //==================================================================
                    Console.Clear();
                    //Configuraciones Generales
                    //Nombre------------------------------------------------
                    Console.WriteLine("Ingrese el nombre de la mascota: ");
                    string nombre = Console.ReadLine();
                    //Peso-------------------------------------------------
                    Console.WriteLine("Ingrese el peso de la mascota: ");
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
                    Console.WriteLine("Ingrese el código de la mascota: ");
                    string codigo = Console.ReadLine();
                    //Estado------------------------------------------------
                    Console.WriteLine("Ingrese si la mascota está enferma (Y/N): ");
                    string inputEnfermo = Console.ReadLine();
                    bool enfermo = inputEnfermo.ToUpper() == "Y";
                    //Tipo de mascota --------------------------------------
                    Console.WriteLine("Ingrese el tipo de mascota (Perro/Gato): ");
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
                    }else if (tipoMascota == "Tortuga")
                    {
                        //Caparazón
                        Console.WriteLine("Ingrese el tipo de caparazón");
                        String caparazon = Console.ReadLine();
                        //Acuatica
                        Console.WriteLine("Indique si la tortuga es acuatica(Y/N)");
                        string inputAcuatica = Console.ReadLine();
                        bool isAcuatica = inputAcuatica.ToUpper() == "Y"; 
                    }else {
                        Console.WriteLine("Tipo de mascota no válido.");

                    }

                    break;
                    //===================================================================
                case "2":
                    Console.Clear();
                    Console.WriteLine("Ingrese el código de la mascota a consultar: ");
                    listaMascotas.buscar(Console.ReadLine());
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Ingrese el código de la mascota a cambiar estado: ");
                    tempMascota = listaMascotas.consultarMascota(Console.ReadLine());
                    if (tempMascota != null)
                    {
                        tempMascota.enfermo = !tempMascota.enfermo;
                        Console.WriteLine("Estado cambiado. Enfermo: " + tempMascota.enfermo);
                    }
                    else
                    {
                        Console.WriteLine("Mascota no encontrada.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Ingrese el codigo de la mascota a consultar");
                    tempMascota= listaMascotas.consultarMascota(Console.ReadLine());
                    if(tempMascota != null)
                    {
                        Console.WriteLine("Nombre de la mascota: "+ tempMascota.nombre);
                        Console.WriteLine("Peso: "+tempMascota.peso+"Kg");
                        if(tempMascota is Perro)
                        {
                            tempDosis = tempMascota.peso * dosis;
                            Console.WriteLine("La dosis necesaria es de: "+tempDosis+"ml");
                        }
                        else if(tempMascota is Gato)
                        {
                            tempDosis = tempMascota.peso * dosis*0.90;
                            Console.WriteLine("La dosis necesaria es de: "+tempDosis+"ml");
                        }
                        else if(tempMascota is Ave)
                        {
                            tempDosis = tempMascota.peso * dosis*0.50;
                            Console.WriteLine("La dosis necesaria es de: "+tempDosis+"ml");
                        }
                        else if(tempMascota is Tortuga)
                        {
                            tempDosis = tempMascota.peso * dosis*0.80;
                            Console.WriteLine("La dosis necesaria es de: "+tempDosis+"ml");
                        }
                    }
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