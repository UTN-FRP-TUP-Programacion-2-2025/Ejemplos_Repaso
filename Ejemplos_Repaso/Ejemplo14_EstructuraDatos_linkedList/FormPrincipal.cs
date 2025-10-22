using Ejemplo14.Models;
using System.Xml.Linq;

namespace Ejemplo14;

public partial class FormPrincipal : Form
{
    LinkedList<Persona> personas = new LinkedList<Persona>();

    public FormPrincipal()
    {
        InitializeComponent();
    }



    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        personas.AddLast(new Persona(42845270, "Ana"));
        personas.AddLast(new Persona(23845633, "Betina"));
        personas.AddLast(new Persona(22245673, "Carmen"));
        personas.AddLast(new Persona(32545684, "Daniel"));
        personas.AddLast(new Persona(22355668, "Ester"));
        personas.AddLast(new Persona(42374634, "Fabian"));
        personas.AddLast(new Persona(42349674, "Gaston"));
        personas.AddLast(new Persona(22385671, "Manuel"));
        personas.AddLast(new Persona(33745992, "Julia"));
        personas.AddLast(new Persona(21745692, "Vanesa"));
        personas.AddLast(new Persona(45545680, "Zamanta"));

        VerContenidoListaEnlazada();
    }

    private void btnInsertarAlPrincipio_Click(object sender, EventArgs e)
    {
        int dni = Convert.ToInt32(tbDNI.Text);
        string nombre = tbNombre.Text;

        Persona nueva = new Persona(dni, nombre);
        personas.AddFirst(nueva);

        VerContenidoListaEnlazada();
        tbDNI.Clear();
        tbNombre.Clear();
    }

    private void btnInsertarAntesDe_Click(object sender, EventArgs e)
    {
        Persona antesDe = lsbVerListaEnlazada.SelectedItem as Persona;

        if (antesDe != null)
        {
            LinkedListNode<Persona> node = personas.Find(antesDe);
            Persona nueva = SolicitarDatos();
            personas.AddBefore(node, nueva);
            ActualizarInterfaz();
        }
        ActualizarInterfaz();
    }

    private void btnInsertarAlFinal_Click(object sender, EventArgs e)
    {
        int dni = Convert.ToInt32(tbDNI.Text);
        string nombre = tbNombre.Text;

        Persona nueva = new Persona(dni, nombre);
        personas.AddLast(nueva);

        VerContenidoListaEnlazada();
        tbDNI.Clear();
        tbNombre.Clear();
    }


    private void lsbVerListaEnlazada_SelectedValueChanged(object sender, EventArgs e)
    {
        Persona seleccion = lsbVerListaEnlazada.SelectedItem as Persona;
        lbSeleccion.Text = $"{seleccion}";
    }

    private void btnInsertarDespuesDe_Click_Click(object sender, EventArgs e)
    {
        Persona despuesDe = lsbVerListaEnlazada.SelectedItem as Persona;

        if (despuesDe != null)
        {
            LinkedListNode<Persona> node = personas.Find(despuesDe);
            Persona nueva = SolicitarDatos();
            personas.AddAfter(node, nueva);
        }
        ActualizarInterfaz();
    }

    private void btnBorrarSeleccion_Click(object sender, EventArgs e)
    {
        Persona selected = lsbVerListaEnlazada.SelectedItem as Persona;

        if (selected != null)
        {
            personas.Remove(selected);
            ActualizarInterfaz();
        }
        ActualizarInterfaz();
    }

    protected void ActualizarInterfaz()
    {
        VerContenidoListaEnlazada();
        tbDNI.Clear();
        tbNombre.Clear();
        lsbVerListaEnlazada.SelectedItem = null;
        lbSeleccion.Text = "Seleccione una persona de la lista";
    }

    protected void VerContenidoListaEnlazada()
    {
        lsbVerListaEnlazada.Items.Clear();
        foreach (Persona persona in personas)
        {
            lsbVerListaEnlazada.Items.Add(persona);
        }
    }

    protected Persona SolicitarDatos()
    {
        int dni = Convert.ToInt32(tbDNI.Text);
        string nombre = tbNombre.Text;
        Persona nueva = new Persona(dni, nombre);
        return nueva;
    }

    private void btnBorrarPrimero_Click(object sender, EventArgs e)
    {
        if (personas.Count > 0)
        {
            personas.RemoveFirst();
            ActualizarInterfaz();
        }
        ActualizarInterfaz();
    }

    private void btnBorrarUltimo_Click(object sender, EventArgs e)
    {
        if(personas.Count > 0)
        { 
            personas.RemoveLast();
            ActualizarInterfaz();
        }
        ActualizarInterfaz();
    }
}
