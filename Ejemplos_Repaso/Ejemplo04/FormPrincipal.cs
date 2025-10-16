using Ejemplo4_jerarquia_de_clases_polimorfismo.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejemplo4;

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
            new Persona( 23222334, "Ana"),
            new Persona( 33252334, "Martín"),
            new Persona( 45426334, "Federico"),
        };
    }

    private void btnDescribir_Click(object sender, EventArgs e)
    {
        personas.Sort(); //ordena a objetos que son ICcomprables 
                         //InvalidOperationException si no implementa IComparable

        //agrega si no existe y sino le actualiza el nombre

        int idx=personas.BinarySearch(new Persona(33252334));//creo un objeto de prueba
        if (idx > -1) //si existe
        {
            personas[idx].Nombre = "Daniela";
        }
        else
        {
            personas.Add(new Persona(33252334, "Daniela"));
        }


        tbDescripcion.Clear();
        foreach (Persona persona in personas)
        { 
            tbDescripcion.AppendText(persona.ToString()+"\r\n");
        }
    }
}
