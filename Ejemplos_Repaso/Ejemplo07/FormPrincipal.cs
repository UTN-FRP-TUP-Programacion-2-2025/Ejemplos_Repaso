using Ejemplo07.Models.Exceptions;
using Ejemplo07.Models;

namespace Ejemplo07;

public partial class FormPrincipal : Form
{
    //List<Persona> personas = new List<Persona>();
    Servicio servicio=new Servicio();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        //inicializar pantalla y controles con valores
        servicio.AgregarPersona(new Persona(23222334, "Ana"));
        servicio.AgregarPersona(new Persona(33252334, "Martín"));
        servicio.AgregarPersona(new Persona(45426334, "Federico"));
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        tbDescripcion.Clear();
        //foreach (Persona persona in personas)
        for(int idx=0; idx<servicio.CantidadPersonas; idx++)
        {
            tbDescripcion.Text += servicio.VerPersona(idx).ToString() + Environment.NewLine;
        }
    }

    private void btnTestCasoNormal_Click(object sender, EventArgs e)
    {
        //manejo de excepciones
        try
        {
            //Persona persona = new Persona(2000324, "Juan");
            //personas.Add(persona);
            servicio.AgregarPersona(new Persona(2000324, "Juan"));
        }
        catch (NombreNoValidoException ex)
        {
            //acción personalizada solo para este caso
            MessageBox.Show("Error: " + ex.Message);
        }
        catch (Exception ex) //la mas general al final - 
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        btnActualizar.PerformClick();
    }

    private void btnTestCaso1_Click(object sender, EventArgs e)
    {
        //manejo de excepciones
        try
        {
            //Persona persona = new Persona(234324, "Juan"); //caso lanzo en el set -   menor a 1000000  
            //personas.Add(persona);
            servicio.AgregarPersona(new Persona(234324, "Juan"));
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        btnActualizar.PerformClick();
    }

    private void btnTestCaso2_Click(object sender, EventArgs e)
    {
        //manejo de excepciones
        try
        {
            //Persona persona = new Persona(230004324, "Juan3"); //caso lanzo en el constructor nombre con caracteres no validos
            //personas.Add(persona);
            servicio.AgregarPersona(new Persona(230004324, "Juan3"));
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        btnActualizar.PerformClick();
    }
}
