namespace Ejemplo06;

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
        btnTestCasoNormal = new Button();
        btnTestCaso1 = new Button();
        btnTestCaso2 = new Button();
        btnActualizar = new Button();
        SuspendLayout();
        // 
        // tbDescripcion
        // 
        tbDescripcion.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        tbDescripcion.Location = new Point(2, 2);
        tbDescripcion.Multiline = true;
        tbDescripcion.Name = "tbDescripcion";
        tbDescripcion.ScrollBars = ScrollBars.Both;
        tbDescripcion.Size = new Size(405, 414);
        tbDescripcion.TabIndex = 14;
        // 
        // btnTestCasoNormal
        // 
        btnTestCasoNormal.Location = new Point(411, 189);
        btnTestCasoNormal.Margin = new Padding(4, 5, 4, 5);
        btnTestCasoNormal.Name = "btnTestCasoNormal";
        btnTestCasoNormal.Size = new Size(112, 66);
        btnTestCasoNormal.TabIndex = 13;
        btnTestCasoNormal.Text = "Test Caso Normal";
        btnTestCasoNormal.UseVisualStyleBackColor = true;
        btnTestCasoNormal.Click += btnTestCasoNormal_Click;
        // 
        // btnTestCaso1
        // 
        btnTestCaso1.Location = new Point(411, 265);
        btnTestCaso1.Margin = new Padding(4, 5, 4, 5);
        btnTestCaso1.Name = "btnTestCaso1";
        btnTestCaso1.Size = new Size(112, 66);
        btnTestCaso1.TabIndex = 15;
        btnTestCaso1.Text = "Test Caso 1";
        btnTestCaso1.UseVisualStyleBackColor = true;
        btnTestCaso1.Click += btnTestCaso1_Click;
        // 
        // btnTestCaso2
        // 
        btnTestCaso2.Location = new Point(411, 341);
        btnTestCaso2.Margin = new Padding(4, 5, 4, 5);
        btnTestCaso2.Name = "btnTestCaso2";
        btnTestCaso2.Size = new Size(112, 66);
        btnTestCaso2.TabIndex = 16;
        btnTestCaso2.Text = "Test Caso 2";
        btnTestCaso2.UseVisualStyleBackColor = true;
        btnTestCaso2.Click += btnTestCaso2_Click;
        // 
        // btnActualizar
        // 
        btnActualizar.Location = new Point(414, 2);
        btnActualizar.Margin = new Padding(4, 5, 4, 5);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new Size(112, 66);
        btnActualizar.TabIndex = 17;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = true;
        btnActualizar.Click += btnActualizar_Click;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(536, 421);
        Controls.Add(btnActualizar);
        Controls.Add(btnTestCaso2);
        Controls.Add(btnTestCaso1);
        Controls.Add(tbDescripcion);
        Controls.Add(btnTestCasoNormal);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += FormPrincipal_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox tbDescripcion;
    private Button btnTestCasoNormal;
    private Button btnTestCaso1;
    private Button btnTestCaso2;
    private Button btnActualizar;
}
