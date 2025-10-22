namespace Ejemplo5
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbDescripcion = new TextBox();
            btnProcesarLista = new Button();
            btnProcesarTexto = new Button();
            SuspendLayout();
            // 
            // tbDescripcion
            // 
            tbDescripcion.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescripcion.Location = new Point(5, 15);
            tbDescripcion.Margin = new Padding(4);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.ScrollBars = ScrollBars.Both;
            tbDescripcion.Size = new Size(323, 154);
            tbDescripcion.TabIndex = 11;
            // 
            // btnProcesarLista
            // 
            btnProcesarLista.Location = new Point(337, 15);
            btnProcesarLista.Margin = new Padding(5, 6, 5, 6);
            btnProcesarLista.Name = "btnProcesarLista";
            btnProcesarLista.Size = new Size(98, 67);
            btnProcesarLista.TabIndex = 10;
            btnProcesarLista.Text = "Procesar Lista (1)";
            btnProcesarLista.UseVisualStyleBackColor = true;
            btnProcesarLista.Click += btnProcesarLista_Click;
            // 
            // btnProcesarTexto
            // 
            btnProcesarTexto.Location = new Point(336, 94);
            btnProcesarTexto.Margin = new Padding(5, 6, 5, 6);
            btnProcesarTexto.Name = "btnProcesarTexto";
            btnProcesarTexto.Size = new Size(98, 67);
            btnProcesarTexto.TabIndex = 12;
            btnProcesarTexto.Text = "Procesar Texto (2)";
            btnProcesarTexto.UseVisualStyleBackColor = true;
            btnProcesarTexto.Click += btnProcesarTexto_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 177);
            Controls.Add(btnProcesarTexto);
            Controls.Add(tbDescripcion);
            Controls.Add(btnProcesarLista);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplo 5. Cadena de caracteres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDescripcion;
        private Button btnProcesarLista;
        private Button btnProcesarTexto;
    }
}
