using System.Reflection;
using System.Text.RegularExpressions;

namespace Ejemplo5;

public partial class FormPrincipal : Form
{
    
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnProcesarLista_Click(object sender, EventArgs e)
    {
        //extreaer numero telefonico
        List<string> telefonos = new List<string>()
        {
            "2323-800427",
            "343-800327",
            "242-404325",
            "2322-200347",

        };

        foreach (string telefono in telefonos)
        {
            int separador = telefono.IndexOf('-');
            string codigoArea = telefono.Substring(0, separador);     //forma equivalente. telefono[..separador];
            string numero = telefono.Substring(separador + 1); //forma equivalente. telefono[(separador+1)..];

            tbDescripcion.Text += $"{codigoArea} | {numero}\r\n";
        }
    }

    private void btnProcesarTexto_Click(object sender, EventArgs e)
    {
        //dado un texto
        string input = @"
2323-800427
343-800327
242-404325
2322-200347";

        tbDescripcion.Clear();
        Match match=Regex.Match(input, @"(\d{3,4})-(\d{6,8})", RegexOptions.IgnoreCase);
        while (match.Success)
        {
            tbDescripcion.Text += $"{match.Groups[1]} | {match.Groups[2]}\r\n";

            match = match.NextMatch();
        }


    }
}
