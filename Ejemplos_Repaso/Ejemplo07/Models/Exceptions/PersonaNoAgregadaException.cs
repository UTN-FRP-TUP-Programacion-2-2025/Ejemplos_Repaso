namespace Ejemplo07.Models.Exceptions;

public class PersonaNoAgregadaException:ApplicationException
{
    public PersonaNoAgregadaException():base("El nombre no es válido") { }
    public PersonaNoAgregadaException(string message) : base(message) { }
    public PersonaNoAgregadaException(string message, Exception inner) : base(message, inner) { }
}
