using Ejemplo06.Models;
using Ejemplo06.Models.Exceptions;

namespace Ejemplo06;

public partial class FormPrincipal : Form
{
    List<Persona> personas = new List<Persona>();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        //inicializar pantalla y controles con valores
        personas = new List<Persona>
        {
            new Persona( 23222331, "Ana"),
            new Persona( 33252333, "Martín"),
            new Persona( 45426334, "Federico"),
            new Persona( 45426333, "Micaela"),
            new Persona( 46426100, "Agustín"),
        };
    }
    private void btnTestCasoNormal_Click(object sender, EventArgs e)
    {
        //manejo de excepciones
        try
        {
            Persona persona = new Persona(2000324, "Juan");
            personas.Add(persona);
        }
        catch (NombreNoValidoException ex)
        {
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
            Persona persona = new Persona(234324, "Juan"); //caso lanzo en el set -   menor a 1000000  
            personas.Add(persona);
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
            Persona persona = new Persona(230004324, "Juan3"); //caso lanzo en el constructor nombre con caracteres no validos
            personas.Add(persona);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        btnActualizar.PerformClick();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        tbDescripcion.Clear();
        foreach (Persona persona in personas)
        {
            tbDescripcion.Text += persona.ToString() + Environment.NewLine;
        }
    }
}
