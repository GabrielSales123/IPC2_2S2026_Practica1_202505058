public class Tortuga : Mascota
{
    private string tipoCaparazon { get; set; }
    private bool esAcuatica { get; set; }

    public string GetTipoCaparazon() { return tipoCaparazon; }
    public void SetTipoCaparazon(string valor) { tipoCaparazon = valor; }

    public string GetEsAcuatica() { 
        if (esAcuatica == true){
            return "✓";
        }
        else
        {
            return "X";
        }
        }

    public Tortuga(String nombre, int peso, int edad, string sexo,
        string propietario, string codigo, bool enfermo, String tipoCaparazon,
        bool esAcuatica)
    {
        this.SetNombre(nombre);
        this.SetPeso(peso);
        this.SetEdad(edad);
        this.SetSexo(sexo);
        this.SetPropietario(propietario);
        this.SetCodigo(codigo);
        this.SetEnfermo(enfermo);
        this.tipoCaparazon = tipoCaparazon;
        this.esAcuatica = esAcuatica;
    }
    public override double CalcularDosis()
    {
        return peso*30*0.8;
    }
}