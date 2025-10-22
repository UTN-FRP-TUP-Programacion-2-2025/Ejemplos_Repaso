namespace Ejemplo13.Models;

[Serializable]
public class Persona 
{
    public int DNI { get; set; }

    public string Nombre { get; set; }

    public Persona()
    { 
    }

    public Persona(int dni)
    {
        this.DNI = dni;
    }

    public Persona(int dni, string nombre):this(dni)
    {
        this.Nombre = nombre;
    }

    override public string ToString()
    {
        return $"{Nombre}({DNI})";
    }
}
