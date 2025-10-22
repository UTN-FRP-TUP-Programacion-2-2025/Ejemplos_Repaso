namespace Ejercicio12;

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
        btnExtraer = new Button();
        btnProcesarLista = new Button();
        groupBox1 = new GroupBox();
        label2 = new Label();
        label1 = new Label();
        tbNombre = new TextBox();
        tbDNI = new TextBox();
        label3 = new Label();
        btnVerUltimo = new Button();
        listBox2 = new ListBox();
        lsbVerPila = new ListBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // btnExtraer
        // 
        btnExtraer.Location = new Point(261, 301);
        btnExtraer.Margin = new Padding(5, 7, 5, 7);
        btnExtraer.Name = "btnExtraer";
        btnExtraer.Size = new Size(125, 78);
        btnExtraer.TabIndex = 15;
        btnExtraer.Text = "Extraer de la Pila (Pop) >>";
        btnExtraer.UseVisualStyleBackColor = true;
        btnExtraer.Click += btnExtraer_Click;
        // 
        // btnProcesarLista
        // 
        btnProcesarLista.Location = new Point(312, 33);
        btnProcesarLista.Margin = new Padding(5, 7, 5, 7);
        btnProcesarLista.Name = "btnProcesarLista";
        btnProcesarLista.Size = new Size(125, 78);
        btnProcesarLista.TabIndex = 13;
        btnProcesarLista.Text = "Insertar en la pila (Push)";
        btnProcesarLista.UseVisualStyleBackColor = true;
        btnProcesarLista.Click += btnProcesarLista_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(tbNombre);
        groupBox1.Controls.Add(tbDNI);
        groupBox1.Controls.Add(btnProcesarLista);
        groupBox1.Location = new Point(15, 15);
        groupBox1.Margin = new Padding(4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4);
        groupBox1.Size = new Size(460, 124);
        groupBox1.TabIndex = 17;
        groupBox1.TabStop = false;
        groupBox1.Text = "Datos";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(15, 77);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(68, 21);
        label2.TabIndex = 3;
        label2.Text = "Nombre";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(15, 38);
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
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(15, 168);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(148, 21);
        label3.TabIndex = 4;
        label3.Text = "Contenido de la Pila";
        // 
        // btnVerUltimo
        // 
        btnVerUltimo.Location = new Point(261, 209);
        btnVerUltimo.Margin = new Padding(5, 7, 5, 7);
        btnVerUltimo.Name = "btnVerUltimo";
        btnVerUltimo.Size = new Size(125, 78);
        btnVerUltimo.TabIndex = 14;
        btnVerUltimo.Text = "Ver el último de la pila (peek)";
        btnVerUltimo.UseVisualStyleBackColor = true;
        btnVerUltimo.Click += btnVerUltimo_Click;
        // 
        // listBox2
        // 
        listBox2.FormattingEnabled = true;
        listBox2.Location = new Point(395, 194);
        listBox2.Margin = new Padding(4);
        listBox2.Name = "listBox2";
        listBox2.Size = new Size(239, 361);
        listBox2.TabIndex = 19;
        // 
        // lsbVerPila
        // 
        lsbVerPila.FormattingEnabled = true;
        lsbVerPila.Location = new Point(13, 194);
        lsbVerPila.Margin = new Padding(4);
        lsbVerPila.Name = "lsbVerPila";
        lsbVerPila.Size = new Size(239, 361);
        lsbVerPila.TabIndex = 20;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(641, 568);
        Controls.Add(lsbVerPila);
        Controls.Add(listBox2);
        Controls.Add(btnVerUltimo);
        Controls.Add(label3);
        Controls.Add(groupBox1);
        Controls.Add(btnExtraer);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += FormPrincipal_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnExtraer;
    private Button btnProcesarLista;
    private GroupBox groupBox1;
    private Label label2;
    private Label label1;
    private TextBox tbNombre;
    private TextBox tbDNI;
    private Label label3;
    private Button btnVerUltimo;
    private ListBox listBox2;
    private ListBox lsbVerPila;
}
