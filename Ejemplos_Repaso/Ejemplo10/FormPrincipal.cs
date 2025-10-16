using Ejemplo10.Models;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejemplo10;

public partial class FormPrincipal : Form
{
    List<Persona> personas = new List<Persona>();

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
            personas = formatter.Deserialize(stream) as List<Persona>;

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
        if (personas == null || personas.Count == 0)
        {
            //inicializar pantalla y controles con valores
            personas = new List<Persona>
            {
                new Persona( 23222334, "Ana"),
                new Persona( 33252334, "Martín"),
                new Persona( 45426334, "Federico"),
            };

        }

        //inializo la pantalla
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

    private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {

        Stream stream = null;
        try
        {
            stream = new FileStream("datos.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            // Remueve las advertencias del compilador sobre obsolescencia
#pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, personas);

            // Remueve las advertencias del compilador sobre obsolescencia
#pragma warning restore SYSLIB0011
        }
        finally
        {
            if (stream != null) stream.Close();
        }
    }

    private void btnAgregarRegistro_Click(object sender, EventArgs e)
    {
        try
        {
            Persona persona = new Persona(2000324, "Juan");
            personas.Add(persona);
        }
        catch (Exception ex) //la mas general al final - 
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        btnActualizar.PerformClick();
    }
}
