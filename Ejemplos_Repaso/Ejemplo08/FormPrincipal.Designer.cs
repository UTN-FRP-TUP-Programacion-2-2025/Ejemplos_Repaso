namespace Ejemplo08;

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
        tbValorCredito = new TextBox();
        listBox1 = new ListBox();
        dtpFechaAprobacion = new DateTimePicker();
        monthCalendar1 = new MonthCalendar();
        btnAprobarCredito = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        SuspendLayout();
        // 
        // tbValorCredito
        // 
        tbValorCredito.Location = new Point(127, 24);
        tbValorCredito.Name = "tbValorCredito";
        tbValorCredito.Size = new Size(100, 25);
        tbValorCredito.TabIndex = 0;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new Point(127, 259);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(460, 89);
        listBox1.TabIndex = 1;
        // 
        // dtpFechaAprobacion
        // 
        dtpFechaAprobacion.CustomFormat = "dd/MM/yyyy";
        dtpFechaAprobacion.Format = DateTimePickerFormat.Custom;
        dtpFechaAprobacion.Location = new Point(127, 73);
        dtpFechaAprobacion.Name = "dtpFechaAprobacion";
        dtpFechaAprobacion.Size = new Size(141, 25);
        dtpFechaAprobacion.TabIndex = 2;
        // 
        // monthCalendar1
        // 
        monthCalendar1.Location = new Point(339, 73);
        monthCalendar1.Name = "monthCalendar1";
        monthCalendar1.TabIndex = 3;
        // 
        // btnAprobarCredito
        // 
        btnAprobarCredito.Location = new Point(253, 12);
        btnAprobarCredito.Name = "btnAprobarCredito";
        btnAprobarCredito.Size = new Size(105, 46);
        btnAprobarCredito.TabIndex = 4;
        btnAprobarCredito.Text = "Aprobar Credito";
        btnAprobarCredito.UseVisualStyleBackColor = true;
        btnAprobarCredito.Click += btnAprobarCredito_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 27);
        label1.Name = "label1";
        label1.Size = new Size(85, 17);
        label1.TabIndex = 5;
        label1.Text = "Valor Credito";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 79);
        label2.Name = "label2";
        label2.Size = new Size(71, 17);
        label2.TabIndex = 6;
        label2.Text = "Aprobado:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(27, 232);
        label3.Name = "label3";
        label3.Size = new Size(48, 17);
        label3.TabIndex = 7;
        label3.Text = "Cuotas";
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(600, 356);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnAprobarCredito);
        Controls.Add(monthCalendar1);
        Controls.Add(dtpFechaAprobacion);
        Controls.Add(listBox1);
        Controls.Add(tbValorCredito);
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

    private TextBox tbValorCredito;
    private ListBox listBox1;
    private DateTimePicker dtpFechaAprobacion;
    private MonthCalendar monthCalendar1;
    private Button btnAprobarCredito;
    private Label label1;
    private Label label2;
    private Label label3;
}
