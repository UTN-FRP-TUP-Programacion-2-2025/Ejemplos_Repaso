using Ejemplo13.Models;

namespace Ejercicio13;

public partial class FormPrincipal : Form
{
    Queue<Persona> personas = new Queue<Persona>();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        personas.Enqueue(new Persona(42845270, "Ana"));
        personas.Enqueue(new Persona(23845633, "Betina"));
        personas.Enqueue(new Persona(22245673, "Carmen"));
        personas.Enqueue(new Persona(32545684, "Daniel"));
        personas.Enqueue(new Persona(22355668, "Ester"));
        personas.Enqueue(new Persona(42374634, "Fabian"));
        personas.Enqueue(new Persona(42349674, "Gaston"));
        personas.Enqueue(new Persona(22385671, "Manuel"));
        personas.Enqueue(new Persona(33745992, "Julia"));
        personas.Enqueue(new Persona(21745692, "Vanesa"));
        personas.Enqueue(new Persona(45545680, "Zamanta"));

        VerContenidoCola();
    }

    private void btnExtraer_Click(object sender, EventArgs e)
    {
        listBox2.Items.Clear();
        if (personas.Count > 0)
        {
            Persona extraccion = personas.Dequeue();
            listBox2.Items.Add(extraccion);
        }
        else
        {
            MessageBox.Show("La pila está vacía");
        }
        VerContenidoCola();
    }

    private void btnPoner_Click(object sender, EventArgs e)
    {
        int dni = Convert.ToInt32(tbDNI.Text);
        string nombre = tbNombre.Text;

        Persona nueva = new Persona(dni, nombre);
        personas.Enqueue(nueva);

        VerContenidoCola();
        tbDNI.Clear();
        tbNombre.Clear();
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

    protected void VerContenidoCola()
    {
        lsbVerCola.Items.Clear();
        foreach (Persona persona in personas)
        {
            lsbVerCola.Items.Add(persona);
        }
    }
}
