using Ejemplo06.Models;

namespace Ejemplo06.Models;

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
            if(VerificarDNI(value)==false)
                throw new Exception("DNI no válido");

            dni = value;
        }
    }

    public string Nombre { get; set; }

    public Persona(int dni)
    {
        this.DNI = dni;//ojo aca porque tiene que pasar por el set
    }

    public Persona(int dni, string nombre):this(dni)
    {
        if (VerificarNombre(nombre) == false)
        {
            throw new NombreNoValidoException($"El nombre: {nombre} es un nombre válido.");
        }

        this.Nombre = nombre;
    }

    protected bool VerificarDNI(int dni)
    {
        if (dni < 1000000 )
            return false;
        return true;
    }

    protected bool VerificarNombre(string nombre)
    {
        foreach (char c in nombre)
        {
            if (!char.IsLetter(c) && c != ' ')
                return false;
        }
        return true;
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
