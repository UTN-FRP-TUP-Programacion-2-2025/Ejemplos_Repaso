namespace Ejemplo06.Models.Exceptions;

public class NombreNoValidoException:ApplicationException
{
    public NombreNoValidoException():base("El nombre no es válido") { }
    public NombreNoValidoException(string message) : base(message) { }
    public NombreNoValidoException(string message, Exception inner) : base(message, inner) { }
}
