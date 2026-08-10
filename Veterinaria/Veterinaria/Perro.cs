public class Perro : Mascota
{
    public Perro(String nombre, int peso, int edad, string sexo,
        string propietario, string codigo, bool enfermo, string raza,
        string tamaño)
    {
        this.nombre = nombre;
        this.peso = peso;
        this.edad = edad;
        this.sexo = sexo;
        this.propietario = propietario;
        this.codigo = codigo;
        this.enfermo = enfermo;
        this.raza = raza;
        this.tamaño = tamaño;
    }
    public string raza {get; set;}
    public string tamaño {get; set;}
}