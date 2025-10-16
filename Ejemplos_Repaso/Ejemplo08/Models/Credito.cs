namespace Ejemplo08.Models;

public class Credito
{
    public double Monto { get; set; }
    DateTime Aprobado { get; set; }

    List<Cuota> cuotas = new List<Cuota>();

    public Credito(double monto, int cuotas, DateTime aprobacion)
    { 
        Aprobado = aprobacion;

        double valorCuota = monto / cuotas; //parte iguales.
        for (int n = 0; n < cuotas; n++)
        {
            #region ejemplo de fechas
            //calcular el proximo mes
            DateTime fecha = Aprobado.AddMonths(n + 1);

            //llevar a los primeros 5 dias habiles
            fecha = new DateTime(fecha.Year, fecha.Month, 1);
            while (fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday || fecha.Day > 5)
            {
                fecha = fecha.AddDays(1);
            }
            #endregion

            this.cuotas.Add(new Cuota(fecha, valorCuota));
        }
    }

    

    public string[] VerDescripcion()
    {
        string[] cuotas = new string[this.cuotas.Count];

        int idx = 0;
        foreach (Cuota cuota in this.cuotas)
        {
            cuotas[idx++] = $"Nro:{idx+1} "+cuota.ToString();
        }
        return cuotas;
    }
}
