using Ejemplo09.Models;

namespace Ejemplo09;

public partial class FormPrincipal : Form
{
    List<Persona> personas = new List<Persona>();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
        tbDescripcion.Clear();
        foreach (Persona persona in personas)
        {
            tbDescripcion.Text += persona.ToString() + Environment.NewLine;
        }
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {

    }

    private void btnImportar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(openFileDialog1.InitialDirectory))
            openFileDialog1.InitialDirectory = Application.StartupPath;

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string path = openFileDialog1.FileName;

            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                while (sr.EndOfStream == false)
                {
                    string linea = sr.ReadLine();
                    string[] campos = linea.Split(";");

                    int dni = Convert.ToInt32(campos[0].Trim());
                    string nombre = campos[1].Trim();

                    int idx = personas.BinarySearch(new Persona(dni));

                    if (idx > -1)
                    {
                        personas[idx].Nombre = nombre;
                    }
                    else
                    {
                        personas.Add(new Persona(dni, nombre));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }

        btnActualizar.PerformClick();
    }

    private void btnExportar_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string path = saveFileDialog1.FileName;

            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                foreach(Persona persona in personas)
                {
                    string linea = $"{persona.DNI};{persona.Nombre}";
                    sw.WriteLine(linea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
