namespace Ejemplo11.Models;

[Serializable]
public class Persona : IComparable
{
    private int dni;
    public int DNI
    {
        get
        {
            return dni;
        }
        set
        {
            dni = value;
        }
    }

    public string Nombre { get; set; }

    public Persona(int dni)
    {
        this.dni = dni;
    }

    public Persona(int dni, string nombre)
    {
        this.dni = dni;
        this.Nombre = nombre;
    }

   

    public int CompareTo(object otherObject)
    {
        Persona other= otherObject as Persona;
        if(other!=null) return this.DNI.CompareTo(other.DNI);
        return -1;
    }

    public override string ToString()
    {
        return $"{Nombre} ({dni})";
    }
}
