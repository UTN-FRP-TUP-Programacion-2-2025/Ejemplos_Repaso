namespace Ejemplo07;

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
        btnTestCaso2 = new Button();
        btnTestCaso1 = new Button();
        tbDescripcion = new TextBox();
        btnTestCasoNormal = new Button();
        SuspendLayout();
        // 
        // btnActualizar
        // 
        btnActualizar.Location = new Point(424, 2);
        btnActualizar.Margin = new Padding(4, 5, 4, 5);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new Size(112, 66);
        btnActualizar.TabIndex = 22;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = true;
        btnActualizar.Click += btnActualizar_Click;
        // 
        // btnTestCaso2
        // 
        btnTestCaso2.Location = new Point(421, 341);
        btnTestCaso2.Margin = new Padding(4, 5, 4, 5);
        btnTestCaso2.Name = "btnTestCaso2";
        btnTestCaso2.Size = new Size(112, 66);
        btnTestCaso2.TabIndex = 21;
        btnTestCaso2.Text = "Test Caso 2";
        btnTestCaso2.UseVisualStyleBackColor = true;
        btnTestCaso2.Click += btnTestCaso2_Click;
        // 
        // btnTestCaso1
        // 
        btnTestCaso1.Location = new Point(421, 265);
        btnTestCaso1.Margin = new Padding(4, 5, 4, 5);
        btnTestCaso1.Name = "btnTestCaso1";
        btnTestCaso1.Size = new Size(112, 66);
        btnTestCaso1.TabIndex = 20;
        btnTestCaso1.Text = "Test Caso 1";
        btnTestCaso1.UseVisualStyleBackColor = true;
        btnTestCaso1.Click += btnTestCaso1_Click;
        // 
        // tbDescripcion
        // 
        tbDescripcion.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        tbDescripcion.Location = new Point(12, 2);
        tbDescripcion.Multiline = true;
        tbDescripcion.Name = "tbDescripcion";
        tbDescripcion.ScrollBars = ScrollBars.Both;
        tbDescripcion.Size = new Size(405, 414);
        tbDescripcion.TabIndex = 19;
        // 
        // btnTestCasoNormal
        // 
        btnTestCasoNormal.Location = new Point(421, 189);
        btnTestCasoNormal.Margin = new Padding(4, 5, 4, 5);
        btnTestCasoNormal.Name = "btnTestCasoNormal";
        btnTestCasoNormal.Size = new Size(112, 66);
        btnTestCasoNormal.TabIndex = 18;
        btnTestCasoNormal.Text = "Test Caso Normal";
        btnTestCasoNormal.UseVisualStyleBackColor = true;
        btnTestCasoNormal.Click += btnTestCasoNormal_Click;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(548, 419);
        Controls.Add(btnActualizar);
        Controls.Add(btnTestCaso2);
        Controls.Add(btnTestCaso1);
        Controls.Add(tbDescripcion);
        Controls.Add(btnTestCasoNormal);
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
    private Button btnTestCaso2;
    private Button btnTestCaso1;
    private TextBox tbDescripcion;
    private Button btnTestCasoNormal;
}
