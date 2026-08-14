public abstract class Mascota
{
    protected string? nombre { get; set; }
    protected int peso { get; set; }
    protected int edad { get; set; }
    protected string? sexo { get; set; }
    protected string? propietario { get; set; }
    protected string? codigo { get; set; }
    protected bool enfermo { get; set; }

    public abstract double CalcularDosis(); 

    public string? GetNombre() { return nombre; }
    public void SetNombre(string? valor) { nombre = valor; }

    public int GetPeso() { return peso; }
    public void SetPeso(int valor) { peso = valor; }

    public int GetEdad() { return edad; }
    public void SetEdad(int valor) { edad = valor; }

    public string? GetSexo() { return sexo; }
    public void SetSexo(string? valor) { sexo = valor; }

    public string? GetPropietario() { return propietario; }
    public void SetPropietario(string? valor) { propietario = valor; }

    public string? GetCodigo() { return codigo; }
    public void SetCodigo(string? valor) { codigo = valor; }

    public bool GetEnfermo() { return enfermo; }
    public void SetEnfermo(bool valor) { enfermo = valor; }

     public string MostrarEnfermo() { 
        if (enfermo == true){
            return "✓";
        }
        else
        {
            return "X";
        }
        }
}