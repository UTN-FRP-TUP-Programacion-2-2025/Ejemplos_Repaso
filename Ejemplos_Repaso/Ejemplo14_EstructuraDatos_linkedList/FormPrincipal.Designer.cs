namespace Ejemplo14;

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
        lsbVerListaEnlazada = new ListBox();
        groupBox1 = new GroupBox();
        label2 = new Label();
        label1 = new Label();
        tbNombre = new TextBox();
        tbDNI = new TextBox();
        btnInsertarAlPrincipio = new Button();
        btnInsertarAlFinal = new Button();
        btnInsertarAntesDe = new Button();
        btnInsertarDespuesDe_Click = new Button();
        lbSeleccion = new Label();
        btnBorrarSeleccion = new Button();
        btnBorrarPrimero = new Button();
        btnBorrarUltimo = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // lsbVerListaEnlazada
        // 
        lsbVerListaEnlazada.FormattingEnabled = true;
        lsbVerListaEnlazada.ItemHeight = 21;
        lsbVerListaEnlazada.Location = new Point(384, 18);
        lsbVerListaEnlazada.Margin = new Padding(4);
        lsbVerListaEnlazada.Name = "lsbVerListaEnlazada";
        lsbVerListaEnlazada.Size = new Size(196, 487);
        lsbVerListaEnlazada.TabIndex = 31;
        lsbVerListaEnlazada.SelectedValueChanged += lsbVerListaEnlazada_SelectedValueChanged;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(tbNombre);
        groupBox1.Controls.Add(tbDNI);
        groupBox1.Location = new Point(40, 13);
        groupBox1.Margin = new Padding(4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4);
        groupBox1.Size = new Size(320, 124);
        groupBox1.TabIndex = 30;
        groupBox1.TabStop = false;
        groupBox1.Text = "Datos";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(17, 79);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(68, 21);
        label2.TabIndex = 3;
        label2.Text = "Nombre";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(17, 40);
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
        // btnInsertarAlPrincipio
        // 
        btnInsertarAlPrincipio.Location = new Point(40, 148);
        btnInsertarAlPrincipio.Margin = new Padding(5, 7, 5, 7);
        btnInsertarAlPrincipio.Name = "btnInsertarAlPrincipio";
        btnInsertarAlPrincipio.Size = new Size(100, 78);
        btnInsertarAlPrincipio.TabIndex = 13;
        btnInsertarAlPrincipio.Text = "Insertar al principio";
        btnInsertarAlPrincipio.UseVisualStyleBackColor = true;
        btnInsertarAlPrincipio.Click += btnInsertarAlPrincipio_Click;
        // 
        // btnInsertarAlFinal
        // 
        btnInsertarAlFinal.Location = new Point(150, 148);
        btnInsertarAlFinal.Margin = new Padding(5, 7, 5, 7);
        btnInsertarAlFinal.Name = "btnInsertarAlFinal";
        btnInsertarAlFinal.Size = new Size(100, 78);
        btnInsertarAlFinal.TabIndex = 32;
        btnInsertarAlFinal.Text = "Insertar al final";
        btnInsertarAlFinal.UseVisualStyleBackColor = true;
        btnInsertarAlFinal.Click += btnInsertarAlFinal_Click;
        // 
        // btnInsertarAntesDe
        // 
        btnInsertarAntesDe.Location = new Point(40, 343);
        btnInsertarAntesDe.Margin = new Padding(5, 7, 5, 7);
        btnInsertarAntesDe.Name = "btnInsertarAntesDe";
        btnInsertarAntesDe.Size = new Size(100, 78);
        btnInsertarAntesDe.TabIndex = 33;
        btnInsertarAntesDe.Text = "Insertar Antes de";
        btnInsertarAntesDe.UseVisualStyleBackColor = true;
        btnInsertarAntesDe.Click += btnInsertarAntesDe_Click;
        // 
        // btnInsertarDespuesDe_Click
        // 
        btnInsertarDespuesDe_Click.Location = new Point(150, 343);
        btnInsertarDespuesDe_Click.Margin = new Padding(5, 7, 5, 7);
        btnInsertarDespuesDe_Click.Name = "btnInsertarDespuesDe_Click";
        btnInsertarDespuesDe_Click.Size = new Size(100, 78);
        btnInsertarDespuesDe_Click.TabIndex = 34;
        btnInsertarDespuesDe_Click.Text = "Insertar Despues de";
        btnInsertarDespuesDe_Click.UseVisualStyleBackColor = true;
        btnInsertarDespuesDe_Click.Click += btnInsertarDespuesDe_Click_Click;
        // 
        // lbSeleccion
        // 
        lbSeleccion.BackColor = SystemColors.ActiveCaption;
        lbSeleccion.Location = new Point(40, 428);
        lbSeleccion.Name = "lbSeleccion";
        lbSeleccion.Size = new Size(320, 58);
        lbSeleccion.TabIndex = 36;
        lbSeleccion.Text = "Seleccione un items de la lista";
        // 
        // btnBorrarSeleccion
        // 
        btnBorrarSeleccion.Location = new Point(260, 343);
        btnBorrarSeleccion.Margin = new Padding(5, 7, 5, 7);
        btnBorrarSeleccion.Name = "btnBorrarSeleccion";
        btnBorrarSeleccion.Size = new Size(100, 78);
        btnBorrarSeleccion.TabIndex = 37;
        btnBorrarSeleccion.Text = "Borrar Selección";
        btnBorrarSeleccion.UseVisualStyleBackColor = true;
        btnBorrarSeleccion.Click += btnBorrarSeleccion_Click;
        // 
        // btnBorrarPrimero
        // 
        btnBorrarPrimero.Location = new Point(40, 240);
        btnBorrarPrimero.Margin = new Padding(5, 7, 5, 7);
        btnBorrarPrimero.Name = "btnBorrarPrimero";
        btnBorrarPrimero.Size = new Size(100, 78);
        btnBorrarPrimero.TabIndex = 38;
        btnBorrarPrimero.Text = "Borrar el Primero";
        btnBorrarPrimero.UseVisualStyleBackColor = true;
        btnBorrarPrimero.Click += btnBorrarPrimero_Click;
        // 
        // btnBorrarUltimo
        // 
        btnBorrarUltimo.Location = new Point(150, 240);
        btnBorrarUltimo.Margin = new Padding(5, 7, 5, 7);
        btnBorrarUltimo.Name = "btnBorrarUltimo";
        btnBorrarUltimo.Size = new Size(100, 78);
        btnBorrarUltimo.TabIndex = 39;
        btnBorrarUltimo.Text = "Borrar el ultimo";
        btnBorrarUltimo.UseVisualStyleBackColor = true;
        btnBorrarUltimo.Click += btnBorrarUltimo_Click;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(587, 508);
        Controls.Add(btnBorrarUltimo);
        Controls.Add(btnBorrarPrimero);
        Controls.Add(btnBorrarSeleccion);
        Controls.Add(lbSeleccion);
        Controls.Add(btnInsertarDespuesDe_Click);
        Controls.Add(btnInsertarAntesDe);
        Controls.Add(btnInsertarAlFinal);
        Controls.Add(lsbVerListaEnlazada);
        Controls.Add(groupBox1);
        Controls.Add(btnInsertarAlPrincipio);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ejemplo 13. Lista Enlazada";
        Load += FormPrincipal_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private ListBox lsbVerListaEnlazada;
    private GroupBox groupBox1;
    private Label label2;
    private Label label1;
    private TextBox tbNombre;
    private TextBox tbDNI;
    private Button btnInsertarAlPrincipio;
    private Button btnInsertarAlFinal;
    private Button btnInsertarAntesDe;
    private Button btnInsertarDespuesDe_Click;
    private Label lbAntesDe;
    private Label lbSeleccion;
    private Button btnBorrarSeleccion;
    private Button btnBorrarPrimero;
    private Button btnBorrarUltimo;
}
