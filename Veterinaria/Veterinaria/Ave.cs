public class Ave : Mascota
{
    private int envergadura { get; set; }
    private bool volador { get; set; }

    public int GetEnvergadura() { return envergadura; }


    public string GetVolador() { 
        if (volador == true){
            return "✓";
        }
        else
        {
            return "X";
        }
        }


    public Ave(String nombre, int peso, int edad, string sexo,
        string propietario, string codigo, bool enfermo, int envergadura,
        bool volador)
    {
        this.SetNombre(nombre);
        this.SetPeso(peso);
        this.SetEdad(edad);
        this.SetSexo(sexo);
        this.SetPropietario(propietario);
        this.SetCodigo(codigo);
        this.SetEnfermo(enfermo);
        this.envergadura = envergadura;
        this.volador = volador;
    }

    public override double CalcularDosis()
    {
        return peso*30*0.5;
    }
}