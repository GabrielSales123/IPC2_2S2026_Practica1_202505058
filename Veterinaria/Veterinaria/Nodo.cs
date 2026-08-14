public class Nodo
{
    public Mascota mascota {get; set;}
    public Nodo? siguiente {get; set;} 
    public Nodo? anterior {get; set;}
    
    public Nodo(Mascota mascota)
    {
        this.mascota = mascota; 
        this.siguiente = null;
        this.anterior = null; 
    }
}