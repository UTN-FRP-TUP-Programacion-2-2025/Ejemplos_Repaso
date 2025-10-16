
namespace Ejemplo11.Models;

[Serializable]
public class Servicio
{

    List<Persona> personas = new List<Persona>();

    //ejemplo 1
    public Persona AgregarPersona(Persona nueva)
    {
        Persona persona = BuscarPersona(nueva.DNI);
        if (persona != null) return null;
        personas.Add(nueva);
        return nueva;
    }

    protected Persona BuscarPersona(int id)
    {
        personas.Sort();
        int idx = personas.BinarySearch(new Persona(id));
        if (idx > -1)
            return personas[idx];
        return null;
    }

    public Persona VerPersona(int idx)
    {
        if (idx >= 0 && idx < personas.Count)
            return personas[idx];
        return null;
    }

    public int CantidadPersonas
    {
        get
        {
            return personas.Count;
        }
    }
}
