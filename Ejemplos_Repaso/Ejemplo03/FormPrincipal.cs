using Ejercicio3.Models;

namespace Ejemplo3;

public partial class FormPrincipal : Form
{
    List<FiguraPlana> figuras = new List<FiguraPlana>();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnDescribir_Click(object sender, EventArgs e)
    {
        figuras.Add(new Circulo(3));
        figuras.Add(new Rectangulo(3,3));

        foreach (FiguraPlana f in figuras)
        { 
            tbDescripcion.Text += f.Describir() + "\r\n";
        }
    }
}
