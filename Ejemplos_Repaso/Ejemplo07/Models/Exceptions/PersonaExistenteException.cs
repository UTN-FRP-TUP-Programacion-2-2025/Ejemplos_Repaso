namespace Ejemplo07.Models.Exceptions;

public class PersonaExistenteException:ApplicationException
{
    public PersonaExistenteException():base("El nombre no es válido") { }
    public PersonaExistenteException(string message) : base(message) { }
    public PersonaExistenteException(string message, Exception inner) : base(message, inner) { }
}
