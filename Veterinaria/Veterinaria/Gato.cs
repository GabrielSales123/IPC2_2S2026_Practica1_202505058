public class Gato : Mascota
{
    private bool esterilizado { get; set; }
    private String raza { get; set; }

    public string GetEsterilizado() { 
        if (esterilizado == true){
            return "✓";
        }
        else
        {
            return "X";
        }
        }

    public String GetRaza() { return raza; }
    

    public Gato(String nombre, int peso, int edad, string sexo,
    string propietario, string codigo, bool enfermo, bool esterilizado,
    String raza)
    {
        this.SetNombre(nombre);
        this.SetPeso(peso);
        this.SetEdad(edad);
        this.SetSexo(sexo);
        this.SetPropietario(propietario);
        this.SetCodigo(codigo);
        this.SetEnfermo(enfermo);
        this.esterilizado = esterilizado;
        this.raza = raza; 
    }

    public override double CalcularDosis()
    {
        return peso*30*0.9;
    }
}