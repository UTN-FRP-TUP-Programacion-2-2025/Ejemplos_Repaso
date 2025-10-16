namespace Ejercicio11
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
            btnActualizar = new Button();
            tbDescripcion = new TextBox();
            btnAgregarRegistro = new Button();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(424, 12);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 66);
            btnActualizar.TabIndex = 28;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescripcion.Location = new Point(12, 12);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.ScrollBars = ScrollBars.Both;
            tbDescripcion.Size = new Size(405, 414);
            tbDescripcion.TabIndex = 27;
            // 
            // btnAgregarRegistro
            // 
            btnAgregarRegistro.Location = new Point(424, 266);
            btnAgregarRegistro.Margin = new Padding(4, 5, 4, 5);
            btnAgregarRegistro.Name = "btnAgregarRegistro";
            btnAgregarRegistro.Size = new Size(112, 66);
            btnAgregarRegistro.TabIndex = 29;
            btnAgregarRegistro.Text = "Agregar Registro";
            btnAgregarRegistro.UseVisualStyleBackColor = true;
            btnAgregarRegistro.Click += btnAgregarRegistro_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(btnAgregarRegistro);
            Controls.Add(btnActualizar);
            Controls.Add(tbDescripcion);
            Name = "FormPrincipal";
            Text = "Ejercicio 11. Archivos binarios - Servicio";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private TextBox tbDescripcion;
        private Button btnAgregarRegistro;
    }
}
