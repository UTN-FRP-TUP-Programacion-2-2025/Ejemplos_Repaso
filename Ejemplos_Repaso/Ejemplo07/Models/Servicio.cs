using Ejemplo07.Models.Exceptions;

namespace Ejemplo07.Models;

public class Servicio
{
    List<Persona> personas = new List<Persona>();

    //ejemplo 1
    public void AgregarPersona(Persona nueva)
    {
        Persona persona = BuscarPersona(nueva.DNI);
        if (persona != null) throw new PersonaExistenteException("La persona ya existe");
        personas.Add(nueva);
    }

    //ejemplo2
    //public void AgregarPersona()
    //{
    //    try
    //    {
    //        Persona persona = new Persona(2000324, "Juan");
    //        personas.Add(persona);
    //    }
    //    catch (Exception ex)
    //    {
    //        throw new PersonaNoAgregadaException("Persona No agregada", ex);
    //    }
    //}

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
