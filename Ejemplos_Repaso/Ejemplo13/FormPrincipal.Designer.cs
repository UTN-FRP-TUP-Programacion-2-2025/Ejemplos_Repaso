namespace Ejercicio13;

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
        lsbVerCola = new ListBox();
        listBox2 = new ListBox();
        btnVerUltimo = new Button();
        label3 = new Label();
        groupBox1 = new GroupBox();
        label2 = new Label();
        label1 = new Label();
        tbNombre = new TextBox();
        tbDNI = new TextBox();
        btnPoner = new Button();
        btnExtraer = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // lsbVerCola
        // 
        lsbVerCola.FormattingEnabled = true;
        lsbVerCola.Location = new Point(11, 192);
        lsbVerCola.Margin = new Padding(4);
        lsbVerCola.Name = "lsbVerCola";
        lsbVerCola.Size = new Size(239, 298);
        lsbVerCola.TabIndex = 26;
        // 
        // listBox2
        // 
        listBox2.FormattingEnabled = true;
        listBox2.Location = new Point(393, 192);
        listBox2.Margin = new Padding(4);
        listBox2.Name = "listBox2";
        listBox2.Size = new Size(239, 298);
        listBox2.TabIndex = 25;
        // 
        // btnVerUltimo
        // 
        btnVerUltimo.Location = new Point(259, 207);
        btnVerUltimo.Margin = new Padding(5, 7, 5, 7);
        btnVerUltimo.Name = "btnVerUltimo";
        btnVerUltimo.Size = new Size(125, 78);
        btnVerUltimo.TabIndex = 22;
        btnVerUltimo.Text = "Ver el primero de la cola (peek)";
        btnVerUltimo.UseVisualStyleBackColor = true;
        btnVerUltimo.Click += btnVerUltimo_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(13, 166);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(405, 21);
        label3.TabIndex = 21;
        label3.Text = "Contenido de la Cola:  Primero en entrar, primero en salir";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(tbNombre);
        groupBox1.Controls.Add(tbDNI);
        groupBox1.Controls.Add(btnPoner);
        groupBox1.Location = new Point(13, 13);
        groupBox1.Margin = new Padding(4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4);
        groupBox1.Size = new Size(499, 124);
        groupBox1.TabIndex = 24;
        groupBox1.TabStop = false;
        groupBox1.Text = "Datos";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(16, 78);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(68, 21);
        label2.TabIndex = 3;
        label2.Text = "Nombre";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(16, 39);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(37, 21);
        label1.TabIndex = 2;
        label1.Text = "DNI";
        // 
        // tbNombre
        // 
        tbNombre.Location = new Point(129, 73);
        tbNombre.Margin = new Padding(4);
        tbNombre.Name = "tbNombre";
        tbNombre.Size = new Size(161, 29);
        tbNombre.TabIndex = 1;
        // 
        // tbDNI
        // 
        tbDNI.Location = new Point(129, 35);
        tbDNI.Margin = new Padding(4);
        tbDNI.Name = "tbDNI";
        tbDNI.Size = new Size(161, 29);
        tbDNI.TabIndex = 0;
        // 
        // btnPoner
        // 
        btnPoner.Location = new Point(356, 33);
        btnPoner.Margin = new Padding(5, 7, 5, 7);
        btnPoner.Name = "btnPoner";
        btnPoner.Size = new Size(125, 78);
        btnPoner.TabIndex = 13;
        btnPoner.Text = "Encolar (Enquee)";
        btnPoner.UseVisualStyleBackColor = true;
        btnPoner.Click += btnPoner_Click;
        // 
        // btnExtraer
        // 
        btnExtraer.Location = new Point(259, 299);
        btnExtraer.Margin = new Padding(5, 7, 5, 7);
        btnExtraer.Name = "btnExtraer";
        btnExtraer.Size = new Size(125, 78);
        btnExtraer.TabIndex = 23;
        btnExtraer.Text = "Desencolar (Dequeue) >>";
        btnExtraer.UseVisualStyleBackColor = true;
        btnExtraer.Click += btnExtraer_Click;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(638, 496);
        Controls.Add(lsbVerCola);
        Controls.Add(listBox2);
        Controls.Add(btnVerUltimo);
        Controls.Add(label3);
        Controls.Add(groupBox1);
        Controls.Add(btnExtraer);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FormPrincipal";
        Text = "Ejemplo 13. Cola";
        Load += FormPrincipal_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox lsbVerCola;
    private ListBox listBox2;
    private Button btnVerUltimo;
    private Label label3;
    private GroupBox groupBox1;
    private Label label2;
    private Label label1;
    private TextBox tbNombre;
    private TextBox tbDNI;
    private Button btnPoner;
    private Button btnExtraer;
}
