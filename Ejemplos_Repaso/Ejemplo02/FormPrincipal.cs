using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDescribir_Click(object sender, EventArgs e)
        {
            Ortoedro ortoedro = new Ortoedro(3, 4, 5);

            tbDescripcion.Text = ortoedro.Describir();
        }
    }
}
