public class Tortuga : Mascota
{
    public string tipoCaparazon {get; set;}
    public bool esAcuatica {get; set;}

    public Tortuga(String nombre, int peso, int edad, string sexo,
        string propietario, string codigo, bool enfermo, String tipoCaparazon,
        bool esAcuatica)
    {
        this.nombre = nombre;
        this.peso = peso;
        this.edad = edad;
        this.sexo = sexo;
        this.propietario = propietario;
        this.codigo = codigo;
        this.enfermo = enfermo;
        this.tipoCaparazon = tipoCaparazon;
        this.tipoCaparazon = tipoCaparazon;
    }
}