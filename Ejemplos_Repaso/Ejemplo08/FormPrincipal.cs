using Ejemplo08.Models;

namespace Ejemplo08;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
    }

    private void btnAprobarCredito_Click(object sender, EventArgs e)
    {
        double tbValorCredito = Convert.ToDouble(this.tbValorCredito.Text);
        DateTime aprobacion = dtpFechaAprobacion.Value;
        
        monthCalendar1.SetDate(aprobacion);
        //monthCalendar1.SelectionStart

        Credito nuevo =new Credito(tbValorCredito, 3,aprobacion);

        //ver impreso
        listBox1.Items.Clear();
        listBox1.Items.AddRange(nuevo.VerDescripcion());
    }
}
