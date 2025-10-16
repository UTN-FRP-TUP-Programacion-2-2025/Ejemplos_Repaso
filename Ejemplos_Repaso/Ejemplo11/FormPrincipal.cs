using Ejemplo11.Models;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio11;

public partial class FormPrincipal : Form
{
    //List<Persona> personas = new List<Persona>();
    Servicio servicio = new Servicio();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        Stream stream = null;
        try
        {
            stream = new FileStream("datos.bin", FileMode.OpenOrCreate, FileAccess.Read);

            // Remueve las advertencias del compilador sobre obsolescencia
#pragma warning disable SYSLIB0011

            BinaryFormatter formatter = new BinaryFormatter();
            //personas = formatter.Deserialize(stream) as List<Persona>;
            servicio = formatter.Deserialize(stream) as Servicio;

            // Remueve las advertencias del compilador sobre obsolescencia
#pragma warning restore SYSLIB0011
        }
        catch (Exception ex)
        {

        }
        finally
        {
            if (stream != null) stream.Close();
        }

        //inicialización
        if (servicio == null || servicio.CantidadPersonas== 0)
        {
            //inicializar pantalla y controles con valores
            /*
            personas = new List<Persona>
            {
                new Persona( 23222334, "Ana"),
                new Persona( 33252334, "Martín"),
                new Persona( 45426334, "Federico"),
            };
            */
            servicio.AgregarPersona(new Persona(23222334, "Ana"));
            servicio.AgregarPersona(new Persona(33252334, "Martín"));
            servicio.AgregarPersona(new Persona(45426334, "Federico"));
        }

        //inializo la pantalla
        btnActualizar.PerformClick();
    }

    private void btnAgregarRegistro_Click(object sender, EventArgs e)
    {
        try
        {
            //Persona persona = new Persona(2000324, "Juan");
            //personas.Add(persona);
            servicio.AgregarPersona(new Persona(2000324, "Juan"));
        }
        catch (Exception ex) //la mas general al final - 
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        btnActualizar.PerformClick();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        tbDescripcion.Clear();
        for (int idx =0; idx<servicio.CantidadPersonas; idx++)
        {
            tbDescripcion.Text += servicio.VerPersona(idx) + Environment.NewLine;
        }
    }
}
