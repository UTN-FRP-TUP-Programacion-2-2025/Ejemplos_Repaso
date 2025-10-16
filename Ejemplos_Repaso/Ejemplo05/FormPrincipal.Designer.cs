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
            tbDescripcion.Location = new Point(4, 12);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.ScrollBars = ScrollBars.Both;
            tbDescripcion.Size = new Size(405, 414);
            tbDescripcion.TabIndex = 11;
            // 
            // btnProcesarLista
            // 
            btnProcesarLista.Location = new Point(416, 52);
            btnProcesarLista.Margin = new Padding(4, 5, 4, 5);
            btnProcesarLista.Name = "btnProcesarLista";
            btnProcesarLista.Size = new Size(112, 66);
            btnProcesarLista.TabIndex = 10;
            btnProcesarLista.Text = "Procesar Lista";
            btnProcesarLista.UseVisualStyleBackColor = true;
            btnProcesarLista.Click += btnProcesarLista_Click;
            // 
            // btnProcesarTexto
            // 
            btnProcesarTexto.Location = new Point(416, 128);
            btnProcesarTexto.Margin = new Padding(4, 5, 4, 5);
            btnProcesarTexto.Name = "btnProcesarTexto";
            btnProcesarTexto.Size = new Size(112, 66);
            btnProcesarTexto.TabIndex = 12;
            btnProcesarTexto.Text = "Procesar Texto";
            btnProcesarTexto.UseVisualStyleBackColor = true;
            btnProcesarTexto.Click += btnProcesarTexto_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 438);
            Controls.Add(btnProcesarTexto);
            Controls.Add(tbDescripcion);
            Controls.Add(btnProcesarLista);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDescripcion;
        private Button btnProcesarLista;
        private Button btnProcesarTexto;
    }
}
