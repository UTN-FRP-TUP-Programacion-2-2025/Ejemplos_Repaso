namespace Ejemplo08.Models;

public class Cuota 
{
    /// primero 5 dias hábiles de cada mes
    public DateTime Vencimiento { get; set; }
    public double Valor { get; set; }

    public Cuota(DateTime vencimiento, double valor)
    {
        Vencimiento = vencimiento;
        Valor = valor;
    }

    public override string ToString()
    {
        return $"Cuota (venc.{Vencimiento:dd/MM/yyyy}) ${Valor:f2} ";
    }
}
