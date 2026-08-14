public class Ave : Mascota
{
    public int envergadura {get; set;}
    public bool volador {get; set;}

    public Ave(String nombre, int peso, int edad, string sexo,
        string propietario, string codigo, bool enfermo, int envergadura,
        bool volador)
    {
        this.nombre = nombre;
        this.peso = peso;
        this.edad = edad;
        this.sexo = sexo;
        this.propietario = propietario;
        this.codigo = codigo;
        this.enfermo = enfermo;
        this.envergadura = envergadura;
        this.volador = volador;
    }
}