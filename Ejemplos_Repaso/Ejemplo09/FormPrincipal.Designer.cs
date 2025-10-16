namespace Ejemplo09;

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
        btnExportar = new Button();
        tbDescripcion = new TextBox();
        openFileDialog1 = new OpenFileDialog();
        saveFileDialog1 = new SaveFileDialog();
        btnImportar = new Button();
        SuspendLayout();
        // 
        // btnActualizar
        // 
        btnActualizar.Location = new Point(424, 12);
        btnActualizar.Margin = new Padding(4, 5, 4, 5);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new Size(112, 66);
        btnActualizar.TabIndex = 22;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = true;
        btnActualizar.Click += btnActualizar_Click;
        // 
        // btnExportar
        // 
        btnExportar.Location = new Point(421, 351);
        btnExportar.Margin = new Padding(4, 5, 4, 5);
        btnExportar.Name = "btnExportar";
        btnExportar.Size = new Size(112, 66);
        btnExportar.TabIndex = 21;
        btnExportar.Text = "Exportar";
        btnExportar.UseVisualStyleBackColor = true;
        btnExportar.Click += btnExportar_Click;
        // 
        // tbDescripcion
        // 
        tbDescripcion.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        tbDescripcion.Location = new Point(12, 12);
        tbDescripcion.Multiline = true;
        tbDescripcion.Name = "tbDescripcion";
        tbDescripcion.ScrollBars = ScrollBars.Both;
        tbDescripcion.Size = new Size(405, 414);
        tbDescripcion.TabIndex = 19;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // btnImportar
        // 
        btnImportar.Location = new Point(421, 275);
        btnImportar.Margin = new Padding(4, 5, 4, 5);
        btnImportar.Name = "btnImportar";
        btnImportar.Size = new Size(112, 66);
        btnImportar.TabIndex = 20;
        btnImportar.Text = "Importar";
        btnImportar.UseVisualStyleBackColor = true;
        btnImportar.Click += btnImportar_Click;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(547, 434);
        Controls.Add(btnActualizar);
        Controls.Add(btnExportar);
        Controls.Add(btnImportar);
        Controls.Add(tbDescripcion);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += FormPrincipal_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnActualizar;
    private Button btnExportar;
    private TextBox tbDescripcion;
    private OpenFileDialog openFileDialog1;
    private SaveFileDialog saveFileDialog1;
    private Button btnImportar;
}
