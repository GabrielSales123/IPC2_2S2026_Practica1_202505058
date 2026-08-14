public class Perro : Mascota
{
    private string raza { get; set; }
    private string tamaño { get; set; }

    public string GetRaza() { return raza; }

    public string GetTamaño() { return tamaño; }
    

    public Perro(String nombre, int peso, int edad, string sexo,
        string propietario, string codigo, bool enfermo, string raza,
        string tamaño)
    {
        this.SetNombre(nombre);
        this.SetPeso(peso);
        this.SetEdad(edad);
        this.SetSexo(sexo);
        this.SetPropietario(propietario);
        this.SetCodigo(codigo);
        this.SetEnfermo(enfermo);
        this.raza = raza;
        this.tamaño = tamaño;
    }

    public override double CalcularDosis()
    {
        return peso*30;
    }
}