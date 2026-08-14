public class ListaMascotas
{
    private Nodo? cabeza {get; set;}
    private Nodo? cola {get; set;}
    private int cont;

    public ListaMascotas()
    {
        this.cabeza = null; 
        this.cola = null;
        this.cont = 0;
    }

    public void agregarMascota(Mascota mascota)
    {
        Nodo nuevoNodo = new Nodo(mascota);
        if (cabeza == null)
        {
            this.cabeza = nuevoNodo; 
            this.cola = nuevoNodo; 
        }
        else
        {
            nuevoNodo.anterior = this.cola;
            this.cola.siguiente = nuevoNodo; 
            this.cola = nuevoNodo; 
        }
        this.cont ++; 
    }
    public void buscar (String codigo)
    {
        bool encontrado = false; 
        Nodo? actual = this.cabeza;
        while(actual != null){
        if(actual.mascota.GetCodigo() == codigo)
        {
            encontrado = true;
            Console.WriteLine("Nombre: " + actual.mascota.GetNombre());
            Console.WriteLine("Peso: " + actual.mascota.GetPeso());
            Console.WriteLine("Edad: " + actual.mascota.GetEdad());
            Console.WriteLine("Sexo: " + actual.mascota.GetSexo());
            Console.WriteLine("Propietario: " + actual.mascota.GetPropietario());
            Console.WriteLine("Codigo: " + actual.mascota.GetCodigo());
            Console.WriteLine("Enfermo: " + actual.mascota.GetEnfermo());
            if(actual.mascota is Perro perro)
                {
                Console.WriteLine("Tipo: Perro");
                Console.WriteLine("Raza: " + perro.GetRaza());
                Console.WriteLine("Tamaño: " + perro.GetTamaño());
                }
            else if(actual.mascota is Gato gato)
                {
                Console.WriteLine("Tipo: Gato");
                Console.WriteLine("Esterilizado: " + gato.GetEsterilizado());    
                }
            else if(actual.mascota is Ave ave)
                {
                Console.WriteLine("Tipo: Ave");
                Console.WriteLine("Envergadura: " + ave.GetEnvergadura());
                Console.WriteLine("Volador: " + ave.GetVolador());    
                }
            else if(actual.mascota is Tortuga tortuga)
                {
                Console.WriteLine("Tipo: Tortuga");
                Console.WriteLine("Tipo de caparazón: " + tortuga.GetTipoCaparazon());
                Console.WriteLine("Es acuática: " + tortuga.GetEsAcuatica());    
                }
        }
        actual = actual.siguiente; 
        }
        if (encontrado == false)
        {
            Console.WriteLine("No se encontró la mascota con el código: " + codigo);
        }
    }

    public void mostrarMascotas()
    {
        Nodo? actual = this.cabeza;
        Console.WriteLine("=======================================");
        while(actual != null)
        {
            Console.WriteLine("Nombre: " + actual.mascota.GetNombre());
            Console.WriteLine("Peso: " + actual.mascota.GetPeso());
            Console.WriteLine("Edad: " + actual.mascota.GetEdad());
            Console.WriteLine("Sexo: " + actual.mascota.GetSexo());
            Console.WriteLine("Propietario: " + actual.mascota.GetPropietario());
            Console.WriteLine("Codigo: " + actual.mascota.GetCodigo());
            Console.WriteLine("Enfermo: " + actual.mascota.MostrarEnfermo());
            if(actual.mascota is Perro perro)
                {
                Console.WriteLine("Tipo: Perro");
                Console.WriteLine("Raza: " + perro.GetRaza());
                Console.WriteLine("Tamaño: " + perro.GetTamaño());
                }
            else if(actual.mascota is Gato gato)
                {
                Console.WriteLine("Tipo: Gato");
                Console.WriteLine("Esterilizado: " + gato.GetEsterilizado());    
                }
            else if(actual.mascota is Ave ave)
                {
                Console.WriteLine("Tipo: Ave");
                Console.WriteLine("Envergadura: " + ave.GetEnvergadura());
                Console.WriteLine("Volador: " + ave.GetVolador());    
                }
            else if(actual.mascota is Tortuga tortuga)
                {
                Console.WriteLine("Tipo: Tortuga");
                Console.WriteLine("Tipo de caparazón: " + tortuga.GetTipoCaparazon());
                Console.WriteLine("Es acuática: " + tortuga.GetEsAcuatica());    
                }
            Console.WriteLine("=========================================");
            actual = actual.siguiente; 

        }
    }

    public Mascota? consultarMascota(string codigo)
    {
        Nodo? actual = this.cabeza;
        while (actual != null)
        {
            if (actual.mascota.GetCodigo() == codigo)
            {
                return actual.mascota;
            }
            actual = actual.siguiente;
        }
        return null;
    }

    public int contMascotas()
    {
        return this.cont; 
    }
}