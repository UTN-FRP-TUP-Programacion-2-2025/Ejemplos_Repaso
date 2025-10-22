using Ejemplo12.Models;

namespace Ejercicio12;

public partial class FormPrincipal : Form
{
    Stack<Persona> personas = new Stack<Persona>();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        //inicializar la pila

        personas.Push(new Persona(42845270, "Ana"));
        personas.Push(new Persona(23845633, "Betina"));
        personas.Push(new Persona(22245673, "Carmen"));
        personas.Push(new Persona(32545684, "Daniel"));
        personas.Push(new Persona(22355668, "Ester"));
        personas.Push(new Persona(42374634, "Fabian"));
        personas.Push(new Persona(42349674, "Gaston"));
        personas.Push(new Persona(22385671, "Manuel"));
        personas.Push(new Persona(33745992, "Julia"));
        personas.Push(new Persona(21745692, "Vanesa"));
        personas.Push(new Persona(45545680, "Zamanta"));

        VerContenidoPila();
    }

    private void btnPoner_Click(object sender, EventArgs e)
    {
        int dni = Convert.ToInt32(tbDNI.Text);
        string nombre = tbNombre.Text;

        Persona nueva = new Persona(dni, nombre);
        personas.Push(nueva);

        VerContenidoPila();

        tbDNI.Clear();
        tbNombre.Clear();
    }

    private void btnExtraer_Click(object sender, EventArgs e)
    {
        listBox2.Items.Clear();
        if (personas.Count > 0)
        {
            Persona extraccion = personas.Pop();
            listBox2.Items.Add(extraccion);
        }
        else
        {
            MessageBox.Show("La pila está vacía");
        }
        VerContenidoPila();
    }

    private void btnVerUltimo_Click(object sender, EventArgs e)
    {
        listBox2.Items.Clear();

        if (personas.Count > 0)
        {
            Persona persona = personas.Peek();
            listBox2.Items.Add(persona);
        }
        else
        {
            MessageBox.Show("La pila está vacía");
        }
    }

    protected void VerContenidoPila()
    {
        lsbVerPila.Items.Clear();
        foreach (Persona persona in personas)
        {
            lsbVerPila.Items.Add(persona);
        }
    }
}
