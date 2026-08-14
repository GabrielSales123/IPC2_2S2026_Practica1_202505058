public class ListaMascotas
{
    public Nodo? cabeza {get; set;}
    public Nodo? cola {get; set;}

    public ListaMascotas()
    {
        this.cabeza = null; 
        this.cola = null;
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
            this.cola.siguiente = nuevoNodo; 
            this.cola = nuevoNodo; 
        }
    }
    public void buscar (String codigo)
    {
        Nodo? actual = this.cabeza;
        while(actual != null){
        if(actual.mascota.codigo == codigo)
        {
            Console.WriteLine("Nombre: " + actual.mascota.nombre);
            Console.WriteLine("Peso: " + actual.mascota.peso);
            Console.WriteLine("Edad: " + actual.mascota.edad);
            Console.WriteLine("Sexo: " + actual.mascota.sexo);
            Console.WriteLine("Propietario: " + actual.mascota.propietario);
            Console.WriteLine("Codigo: " + actual.mascota.codigo);
            Console.WriteLine("Enfermo: " + actual.mascota.enfermo);
            if(actual.mascota is Perro perro)
                {
                Console.WriteLine("Tipo: Perro");
                Console.WriteLine("Raza: " + perro.raza);
                Console.WriteLine("Tamaño: " + perro.tamaño);
                }
            else if(actual.mascota is Gato gato)
                {
                Console.WriteLine("Tipo: Gato");
                Console.WriteLine("Esterilizado: " + gato.esterilizado);    
                }
            else if(actual.mascota is Ave ave)
                {
                Console.WriteLine("Tipo: Ave");
                Console.WriteLine("Envergadura: " + ave.envergadura);
                Console.WriteLine("Volador: " + ave.volador);    
                }
            else if(actual.mascota is Tortuga tortuga)
                {
                Console.WriteLine("Tipo: Tortuga");
                Console.WriteLine("Tipo de caparazón: " + tortuga.tipoCaparazon);
                Console.WriteLine("Es acuática: " + tortuga.esAcuatica);    
                }
        }
        actual = actual.siguiente; 
        }
        if (actual == this.cola.siguiente)
        {
            Console.WriteLine("No se encontró la mascota con el código: " + codigo);
        }
    }

    public void mostrarMascotas()
    {
        Nodo? actual = this.cabeza;
        while(actual != null)
        {
            Console.WriteLine("Nombre: " + actual.mascota.nombre);
            actual = actual.siguiente; 
        }
    }

    public Mascota? consultarMascota(string codigo)
    {
        Nodo? actual = this.cabeza;
        while (actual != null)
        {
            if (actual.mascota.codigo == codigo)
            {
                return actual.mascota;
            }
            actual = actual.siguiente;
        }
        return null;
    }
}