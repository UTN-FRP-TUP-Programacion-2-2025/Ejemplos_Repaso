namespace Ejemplo10;

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
        btnActualizar.Location = new Point(419, 14);
        btnActualizar.Margin = new Padding(4, 5, 4, 5);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new Size(112, 66);
        btnActualizar.TabIndex = 26;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = true;
        btnActualizar.Click += btnActualizar_Click;
        // 
        // tbDescripcion
        // 
        tbDescripcion.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        tbDescripcion.Location = new Point(7, 14);
        tbDescripcion.Multiline = true;
        tbDescripcion.Name = "tbDescripcion";
        tbDescripcion.ScrollBars = ScrollBars.Both;
        tbDescripcion.Size = new Size(405, 414);
        tbDescripcion.TabIndex = 23;
        // 
        // btnAgregarRegistro
        // 
        btnAgregarRegistro.Location = new Point(419, 237);
        btnAgregarRegistro.Margin = new Padding(4, 5, 4, 5);
        btnAgregarRegistro.Name = "btnAgregarRegistro";
        btnAgregarRegistro.Size = new Size(112, 66);
        btnAgregarRegistro.TabIndex = 27;
        btnAgregarRegistro.Text = "Agregar Registro";
        btnAgregarRegistro.UseVisualStyleBackColor = true;
        btnAgregarRegistro.Click += btnAgregarRegistro_Click;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(535, 436);
        Controls.Add(btnAgregarRegistro);
        Controls.Add(btnActualizar);
        Controls.Add(tbDescripcion);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Archivos Binarios";
        FormClosing += FormPrincipal_FormClosing;
        Load += FormPrincipal_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnActualizar;
    private TextBox tbDescripcion;
    private Button btnAgregarRegistro;
}
