namespace Ejemplo4
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
            btnDescribir = new Button();
            SuspendLayout();
            // 
            // tbDescripcion
            // 
            tbDescripcion.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescripcion.Location = new Point(7, 2);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.ScrollBars = ScrollBars.Both;
            tbDescripcion.Size = new Size(405, 428);
            tbDescripcion.TabIndex = 9;
            // 
            // btnDescribir
            // 
            btnDescribir.Location = new Point(419, 160);
            btnDescribir.Margin = new Padding(4, 5, 4, 5);
            btnDescribir.Name = "btnDescribir";
            btnDescribir.Size = new Size(112, 66);
            btnDescribir.TabIndex = 8;
            btnDescribir.Text = "Procesar";
            btnDescribir.UseVisualStyleBackColor = true;
            btnDescribir.Click += btnDescribir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 431);
            Controls.Add(tbDescripcion);
            Controls.Add(btnDescribir);
            Font = new Font("Segoe UI", 10F);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDescripcion;
        private Button btnDescribir;
    }
}
