public class Program
{
    public static bool isRunning = true;

    public static void Main(string[] args)
    {
        ListaMascotas listaMascotas = new ListaMascotas();
        listaMascotas.agregarMascota(new Perro("Firulais", 10, 3, "Mencho", "Juan Perez", "1", false, "Labrador", "Grande"));
        listaMascotas.agregarMascota(new Perro("Firulais2", 10, 3, "Mencho", "Juan Perez", "2", false, "Labrador", "Grande"));
        listaMascotas.agregarMascota(new Perro("Firulais3", 10, 3, "Mencho", "Juan Perez", "3", false, "Labrador", "Grande"));
        listaMascotas.mostrarMascotas();

        while (isRunning)
        {
            Console.WriteLine("============Veterinaria============");
            Console.WriteLine("Bienvenido a la Veterinaria");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Registrar mascota");
            Console.WriteLine("2. Consultar mascota");
            Console.WriteLine("3. Salir");
            Console.WriteLine("====================================");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Ingrese el nombre de la mascota: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el peso de la mascota: ");
                    int peso = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad de la mascota: ");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el sexo de la mascota: ");
                    string sexo = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre del propietario: ");
                    string propietario = Console.ReadLine();
                    Console.WriteLine("Ingrese el código de la mascota: ");
                    string codigo = Console.ReadLine();
                    Console.WriteLine("Ingrese si la mascota está enferma (Y/N): ");
                    string inputEnfermo = Console.ReadLine();
                    bool enfermo = inputEnfermo.ToUpper() == "Y";
                    Console.WriteLine("Ingrese el tipo de mascota (Perro/Gato): ");
                    string tipoMascota = Console.ReadLine();
                    if(tipoMascota == "Perro"){
                        Console.WriteLine("Ingrese la raza del perro: ");
                        string raza = Console.ReadLine();
                        Console.WriteLine("Ingrese el tamaño del perro: ");
                        string tamaño = Console.ReadLine();
                        listaMascotas.agregarMascota(new Perro(nombre, peso, edad, sexo, propietario, codigo, enfermo, raza, tamaño));
                    } else if(tipoMascota == "Gato"){
                        
                    } else {
                        Console.WriteLine("Tipo de mascota no válido.");

                    }

                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Ingrese el código de la mascota a consultar: ");
                    listaMascotas.buscar(Console.ReadLine());
                    break;
                case "3":
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