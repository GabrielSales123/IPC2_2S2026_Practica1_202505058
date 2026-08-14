public class Gato : Mascota
{
    public bool esterilizado {get; set;}
    public String raza {get; set;}

    public Gato(String nombre, int peso, int edad, string sexo,
    string propietario, string codigo, bool enfermo, bool esterilizado,
    String raza)
    {
        this.nombre = nombre;
        this.peso = peso;
        this.edad = edad;
        this.sexo = sexo;
        this.propietario = propietario;
        this.codigo = codigo;
        this.enfermo = enfermo;
        this.esterilizado = esterilizado;
        this.raza = raza; 
    }
}