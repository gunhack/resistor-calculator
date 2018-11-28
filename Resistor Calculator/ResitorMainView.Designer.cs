namespace Resistor_Calculator {
  partial class ResitorMainView {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.BCalcular = new System.Windows.Forms.Button();
      this.BLimpiar = new System.Windows.Forms.Button();
      this.DGVResistencias = new System.Windows.Forms.DataGridView();
      this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Resistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NUDVoltaje = new System.Windows.Forms.NumericUpDown();
      this.BSerie = new System.Windows.Forms.GroupBox();
      this.CBAmpers = new System.Windows.Forms.ComboBox();
      this.NUDAmpers = new System.Windows.Forms.NumericUpDown();
      this.RBVoltaje = new System.Windows.Forms.RadioButton();
      this.RBAmpers = new System.Windows.Forms.RadioButton();
      this.BEditar = new System.Windows.Forms.Button();
      this.CBOhmsExp = new System.Windows.Forms.ComboBox();
      this.BEliminar = new System.Windows.Forms.Button();
      this.CBVoltsExp = new System.Windows.Forms.ComboBox();
      this.NUDValor = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.BAgregar = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.GBResultados = new System.Windows.Forms.GroupBox();
      this.TBResults = new System.Windows.Forms.TextBox();
      this.GBOpciones = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.CBMostRes = new System.Windows.Forms.ComboBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.CBVoltage = new System.Windows.Forms.CheckBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.CBPot = new System.Windows.Forms.CheckBox();
      this.CBVoltsXRes = new System.Windows.Forms.CheckBox();
      this.CBIntensidad = new System.Windows.Forms.CheckBox();
      this.CBResTot = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.DGVResistencias)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NUDVoltaje)).BeginInit();
      this.BSerie.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NUDAmpers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NUDValor)).BeginInit();
      this.GBResultados.SuspendLayout();
      this.GBOpciones.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // BCalcular
      // 
      this.BCalcular.Location = new System.Drawing.Point(441, 179);
      this.BCalcular.Name = "BCalcular";
      this.BCalcular.Size = new System.Drawing.Size(86, 32);
      this.BCalcular.TabIndex = 1;
      this.BCalcular.Text = "Calcular!";
      this.BCalcular.UseVisualStyleBackColor = true;
      this.BCalcular.Click += new System.EventHandler(this.BCalcular_Click);
      // 
      // BLimpiar
      // 
      this.BLimpiar.Location = new System.Drawing.Point(441, 101);
      this.BLimpiar.Name = "BLimpiar";
      this.BLimpiar.Size = new System.Drawing.Size(86, 32);
      this.BLimpiar.TabIndex = 2;
      this.BLimpiar.Text = "Limpiar";
      this.BLimpiar.UseVisualStyleBackColor = true;
      this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
      // 
      // DGVResistencias
      // 
      this.DGVResistencias.AllowUserToAddRows = false;
      this.DGVResistencias.AllowUserToDeleteRows = false;
      this.DGVResistencias.AllowUserToResizeColumns = false;
      this.DGVResistencias.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.Format = "N2";
      dataGridViewCellStyle1.NullValue = null;
      this.DGVResistencias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.DGVResistencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.DGVResistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DGVResistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Resistencia});
      this.DGVResistencias.Location = new System.Drawing.Point(234, 23);
      this.DGVResistencias.Name = "DGVResistencias";
      this.DGVResistencias.ReadOnly = true;
      this.DGVResistencias.RowHeadersWidth = 25;
      this.DGVResistencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.DGVResistencias.RowTemplate.Height = 24;
      this.DGVResistencias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.DGVResistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.DGVResistencias.Size = new System.Drawing.Size(201, 188);
      this.DGVResistencias.TabIndex = 0;
      // 
      // Numero
      // 
      this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      dataGridViewCellStyle2.Format = "N0";
      this.Numero.DefaultCellStyle = dataGridViewCellStyle2;
      this.Numero.Frozen = true;
      this.Numero.HeaderText = "No.";
      this.Numero.Name = "Numero";
      this.Numero.ReadOnly = true;
      this.Numero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.Numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Numero.Width = 35;
      // 
      // Resistencia
      // 
      dataGridViewCellStyle3.NullValue = null;
      this.Resistencia.DefaultCellStyle = dataGridViewCellStyle3;
      this.Resistencia.Frozen = true;
      this.Resistencia.HeaderText = "Valor";
      this.Resistencia.Name = "Resistencia";
      this.Resistencia.ReadOnly = true;
      this.Resistencia.Width = 75;
      // 
      // NUDVoltaje
      // 
      this.NUDVoltaje.Location = new System.Drawing.Point(94, 119);
      this.NUDVoltaje.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.NUDVoltaje.Name = "NUDVoltaje";
      this.NUDVoltaje.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.NUDVoltaje.Size = new System.Drawing.Size(74, 22);
      this.NUDVoltaje.TabIndex = 5;
      this.NUDVoltaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.NUDVoltaje.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
      // 
      // BSerie
      // 
      this.BSerie.Controls.Add(this.CBAmpers);
      this.BSerie.Controls.Add(this.NUDAmpers);
      this.BSerie.Controls.Add(this.RBVoltaje);
      this.BSerie.Controls.Add(this.RBAmpers);
      this.BSerie.Controls.Add(this.BEditar);
      this.BSerie.Controls.Add(this.CBOhmsExp);
      this.BSerie.Controls.Add(this.BEliminar);
      this.BSerie.Controls.Add(this.CBVoltsExp);
      this.BSerie.Controls.Add(this.NUDValor);
      this.BSerie.Controls.Add(this.label3);
      this.BSerie.Controls.Add(this.BAgregar);
      this.BSerie.Controls.Add(this.label2);
      this.BSerie.Controls.Add(this.label1);
      this.BSerie.Controls.Add(this.DGVResistencias);
      this.BSerie.Controls.Add(this.BLimpiar);
      this.BSerie.Controls.Add(this.NUDVoltaje);
      this.BSerie.Controls.Add(this.BCalcular);
      this.BSerie.Location = new System.Drawing.Point(12, 12);
      this.BSerie.Name = "BSerie";
      this.BSerie.Size = new System.Drawing.Size(533, 230);
      this.BSerie.TabIndex = 7;
      this.BSerie.TabStop = false;
      this.BSerie.Text = "Valores";
      // 
      // CBAmpers
      // 
      this.CBAmpers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CBAmpers.Enabled = false;
      this.CBAmpers.FormattingEnabled = true;
      this.CBAmpers.Items.AddRange(new object[] {
            "MA",
            "kA",
            "A",
            "mA",
            "µA",
            "nA",
            "pA"});
      this.CBAmpers.Location = new System.Drawing.Point(175, 164);
      this.CBAmpers.Name = "CBAmpers";
      this.CBAmpers.Size = new System.Drawing.Size(53, 24);
      this.CBAmpers.TabIndex = 23;
      // 
      // NUDAmpers
      // 
      this.NUDAmpers.Enabled = false;
      this.NUDAmpers.Location = new System.Drawing.Point(95, 165);
      this.NUDAmpers.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.NUDAmpers.Name = "NUDAmpers";
      this.NUDAmpers.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.NUDAmpers.Size = new System.Drawing.Size(74, 22);
      this.NUDAmpers.TabIndex = 22;
      this.NUDAmpers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.NUDAmpers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // RBVoltaje
      // 
      this.RBVoltaje.AutoSize = true;
      this.RBVoltaje.Checked = true;
      this.RBVoltaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.RBVoltaje.Location = new System.Drawing.Point(5, 119);
      this.RBVoltaje.Name = "RBVoltaje";
      this.RBVoltaje.Size = new System.Drawing.Size(79, 21);
      this.RBVoltaje.TabIndex = 21;
      this.RBVoltaje.TabStop = true;
      this.RBVoltaje.Text = "Voltaje";
      this.RBVoltaje.UseVisualStyleBackColor = true;
      this.RBVoltaje.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
      // 
      // RBAmpers
      // 
      this.RBAmpers.AutoSize = true;
      this.RBAmpers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.RBAmpers.Location = new System.Drawing.Point(6, 166);
      this.RBAmpers.Name = "RBAmpers";
      this.RBAmpers.Size = new System.Drawing.Size(83, 21);
      this.RBAmpers.TabIndex = 20;
      this.RBAmpers.Text = "Ampers";
      this.RBAmpers.UseVisualStyleBackColor = true;
      this.RBAmpers.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // BEditar
      // 
      this.BEditar.Location = new System.Drawing.Point(441, 25);
      this.BEditar.Name = "BEditar";
      this.BEditar.Size = new System.Drawing.Size(86, 32);
      this.BEditar.TabIndex = 19;
      this.BEditar.Text = "Editar";
      this.BEditar.UseVisualStyleBackColor = true;
      this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
      // 
      // CBOhmsExp
      // 
      this.CBOhmsExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CBOhmsExp.FormattingEnabled = true;
      this.CBOhmsExp.Items.AddRange(new object[] {
            "MΩ",
            "kΩ",
            "Ω",
            "mΩ",
            "µΩ",
            "nΩ",
            "pΩ"});
      this.CBOhmsExp.Location = new System.Drawing.Point(174, 39);
      this.CBOhmsExp.Name = "CBOhmsExp";
      this.CBOhmsExp.Size = new System.Drawing.Size(54, 24);
      this.CBOhmsExp.TabIndex = 11;
      // 
      // BEliminar
      // 
      this.BEliminar.Location = new System.Drawing.Point(441, 63);
      this.BEliminar.Name = "BEliminar";
      this.BEliminar.Size = new System.Drawing.Size(86, 32);
      this.BEliminar.TabIndex = 18;
      this.BEliminar.Text = "Eliminar";
      this.BEliminar.UseVisualStyleBackColor = true;
      this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
      // 
      // CBVoltsExp
      // 
      this.CBVoltsExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CBVoltsExp.FormattingEnabled = true;
      this.CBVoltsExp.Items.AddRange(new object[] {
            "MV",
            "kV",
            "V",
            "mV",
            "µV",
            "nV",
            "pV"});
      this.CBVoltsExp.Location = new System.Drawing.Point(174, 119);
      this.CBVoltsExp.Name = "CBVoltsExp";
      this.CBVoltsExp.Size = new System.Drawing.Size(54, 24);
      this.CBVoltsExp.TabIndex = 17;
      // 
      // NUDValor
      // 
      this.NUDValor.Location = new System.Drawing.Point(94, 40);
      this.NUDValor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.NUDValor.Name = "NUDValor";
      this.NUDValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.NUDValor.Size = new System.Drawing.Size(74, 22);
      this.NUDValor.TabIndex = 16;
      this.NUDValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.NUDValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(391, 305);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(0, 17);
      this.label3.TabIndex = 15;
      // 
      // BAgregar
      // 
      this.BAgregar.Location = new System.Drawing.Point(94, 69);
      this.BAgregar.Name = "BAgregar";
      this.BAgregar.Size = new System.Drawing.Size(134, 27);
      this.BAgregar.TabIndex = 14;
      this.BAgregar.Text = "Agregar";
      this.BAgregar.UseVisualStyleBackColor = true;
      this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(37, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(51, 17);
      this.label2.TabIndex = 13;
      this.label2.Text = "Valor:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(59, 139);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(0, 17);
      this.label1.TabIndex = 9;
      // 
      // GBResultados
      // 
      this.GBResultados.Controls.Add(this.TBResults);
      this.GBResultados.Location = new System.Drawing.Point(12, 248);
      this.GBResultados.Name = "GBResultados";
      this.GBResultados.Size = new System.Drawing.Size(689, 298);
      this.GBResultados.TabIndex = 8;
      this.GBResultados.TabStop = false;
      this.GBResultados.Text = "Resultados";
      // 
      // TBResults
      // 
      this.TBResults.Location = new System.Drawing.Point(6, 21);
      this.TBResults.Multiline = true;
      this.TBResults.Name = "TBResults";
      this.TBResults.ReadOnly = true;
      this.TBResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.TBResults.Size = new System.Drawing.Size(678, 271);
      this.TBResults.TabIndex = 0;
      // 
      // GBOpciones
      // 
      this.GBOpciones.Controls.Add(this.label4);
      this.GBOpciones.Controls.Add(this.CBMostRes);
      this.GBOpciones.Controls.Add(this.panel1);
      this.GBOpciones.Location = new System.Drawing.Point(551, 12);
      this.GBOpciones.Name = "GBOpciones";
      this.GBOpciones.Size = new System.Drawing.Size(151, 230);
      this.GBOpciones.TabIndex = 9;
      this.GBOpciones.TabStop = false;
      this.GBOpciones.Text = "Opciones";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(6, 195);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(91, 17);
      this.label4.TabIndex = 20;
      this.label4.Text = "Mostrar en:";
      // 
      // CBMostRes
      // 
      this.CBMostRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CBMostRes.FormattingEnabled = true;
      this.CBMostRes.Items.AddRange(new object[] {
            "M",
            "k ",
            "-",
            "m ",
            "µ",
            "n",
            "p"});
      this.CBMostRes.Location = new System.Drawing.Point(102, 192);
      this.CBMostRes.Name = "CBMostRes";
      this.CBMostRes.Size = new System.Drawing.Size(43, 24);
      this.CBMostRes.TabIndex = 20;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.CBVoltage);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Controls.Add(this.CBPot);
      this.panel1.Controls.Add(this.CBVoltsXRes);
      this.panel1.Controls.Add(this.CBIntensidad);
      this.panel1.Controls.Add(this.CBResTot);
      this.panel1.Location = new System.Drawing.Point(6, 18);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(139, 168);
      this.panel1.TabIndex = 0;
      // 
      // CBVoltage
      // 
      this.CBVoltage.AutoSize = true;
      this.CBVoltage.Enabled = false;
      this.CBVoltage.Location = new System.Drawing.Point(3, 86);
      this.CBVoltage.Name = "CBVoltage";
      this.CBVoltage.Size = new System.Drawing.Size(73, 21);
      this.CBVoltage.TabIndex = 5;
      this.CBVoltage.Text = "Voltaje";
      this.CBVoltage.UseVisualStyleBackColor = true;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Location = new System.Drawing.Point(3, 5);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(141, 21);
      this.checkBox1.TabIndex = 4;
      this.checkBox1.Text = "Seleccionar Todo";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // CBPot
      // 
      this.CBPot.AutoSize = true;
      this.CBPot.Checked = true;
      this.CBPot.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CBPot.Location = new System.Drawing.Point(2, 140);
      this.CBPot.Name = "CBPot";
      this.CBPot.Size = new System.Drawing.Size(89, 21);
      this.CBPot.TabIndex = 3;
      this.CBPot.Text = "Wats p/Ω";
      this.CBPot.UseVisualStyleBackColor = true;
      // 
      // CBVoltsXRes
      // 
      this.CBVoltsXRes.AutoSize = true;
      this.CBVoltsXRes.Checked = true;
      this.CBVoltsXRes.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CBVoltsXRes.Location = new System.Drawing.Point(3, 113);
      this.CBVoltsXRes.Name = "CBVoltsXRes";
      this.CBVoltsXRes.Size = new System.Drawing.Size(107, 21);
      this.CBVoltsXRes.TabIndex = 2;
      this.CBVoltsXRes.Text = "Voltajes p/Ω";
      this.CBVoltsXRes.UseVisualStyleBackColor = true;
      // 
      // CBIntensidad
      // 
      this.CBIntensidad.AutoSize = true;
      this.CBIntensidad.Checked = true;
      this.CBIntensidad.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CBIntensidad.Location = new System.Drawing.Point(3, 59);
      this.CBIntensidad.Name = "CBIntensidad";
      this.CBIntensidad.Size = new System.Drawing.Size(87, 21);
      this.CBIntensidad.TabIndex = 1;
      this.CBIntensidad.Text = "Intesidad";
      this.CBIntensidad.UseVisualStyleBackColor = true;
      // 
      // CBResTot
      // 
      this.CBResTot.AutoSize = true;
      this.CBResTot.Checked = true;
      this.CBResTot.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CBResTot.Location = new System.Drawing.Point(3, 32);
      this.CBResTot.Name = "CBResTot";
      this.CBResTot.Size = new System.Drawing.Size(92, 21);
      this.CBResTot.TabIndex = 0;
      this.CBResTot.Text = "Ω Totales";
      this.CBResTot.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(711, 546);
      this.Controls.Add(this.BSerie);
      this.Controls.Add(this.GBOpciones);
      this.Controls.Add(this.GBResultados);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Calculadora de Circuitos";
      ((System.ComponentModel.ISupportInitialize)(this.DGVResistencias)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NUDVoltaje)).EndInit();
      this.BSerie.ResumeLayout(false);
      this.BSerie.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.NUDAmpers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NUDValor)).EndInit();
      this.GBResultados.ResumeLayout(false);
      this.GBResultados.PerformLayout();
      this.GBOpciones.ResumeLayout(false);
      this.GBOpciones.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridView DGVResistencias;
    private System.Windows.Forms.Button BCalcular;
    private System.Windows.Forms.Button BLimpiar;
    private System.Windows.Forms.NumericUpDown NUDVoltaje;
    private System.Windows.Forms.GroupBox BSerie;
    private System.Windows.Forms.ComboBox CBOhmsExp;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button BAgregar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown NUDValor;
    private System.Windows.Forms.ComboBox CBVoltsExp;
    private System.Windows.Forms.Button BEditar;
    private System.Windows.Forms.Button BEliminar;
    private System.Windows.Forms.GroupBox GBResultados;
    private System.Windows.Forms.TextBox TBResults;
    private System.Windows.Forms.GroupBox GBOpciones;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox CBVoltsXRes;
    private System.Windows.Forms.CheckBox CBIntensidad;
    private System.Windows.Forms.CheckBox CBResTot;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox CBMostRes;
    private System.Windows.Forms.CheckBox CBPot;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
    private System.Windows.Forms.DataGridViewTextBoxColumn Resistencia;
    private System.Windows.Forms.RadioButton RBVoltaje;
    private System.Windows.Forms.RadioButton RBAmpers;
    private System.Windows.Forms.ComboBox CBAmpers;
    private System.Windows.Forms.NumericUpDown NUDAmpers;
    private System.Windows.Forms.CheckBox CBVoltage;
  }
}

