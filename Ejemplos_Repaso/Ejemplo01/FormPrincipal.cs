using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDescribir_Click(object sender, EventArgs e)
        {
            Rectangulo nuevo = new Rectangulo(3,4);
            tbDescripcion.Text += nuevo.Describir(); 
        }
     }
}
