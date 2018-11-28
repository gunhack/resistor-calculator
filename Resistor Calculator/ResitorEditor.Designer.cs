namespace Resistor_Calculator {
  partial class ResitorEditor {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.NUDValor = new System.Windows.Forms.NumericUpDown();
      this.BAgregar = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.CBOhmsExp = new System.Windows.Forms.ComboBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.NUDValor)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // NUDValor
      // 
      this.NUDValor.Location = new System.Drawing.Point(69, 18);
      this.NUDValor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.NUDValor.Name = "NUDValor";
      this.NUDValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.NUDValor.Size = new System.Drawing.Size(74, 22);
      this.NUDValor.TabIndex = 20;
      this.NUDValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.NUDValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // BAgregar
      // 
      this.BAgregar.Location = new System.Drawing.Point(28, 19);
      this.BAgregar.Name = "BAgregar";
      this.BAgregar.Size = new System.Drawing.Size(121, 32);
      this.BAgregar.TabIndex = 19;
      this.BAgregar.Text = "Aceptar";
      this.BAgregar.UseVisualStyleBackColor = true;
      this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 20);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(51, 17);
      this.label2.TabIndex = 18;
      this.label2.Text = "Valor:";
      // 
      // CBOhmsExp
      // 
      this.CBOhmsExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CBOhmsExp.FormattingEnabled = true;
      this.CBOhmsExp.Items.AddRange(new object[] {
            "MΩ ( x10^6 )",
            "kΩ ( x10^3 ) ",
            "Ω ( x10^0 )",
            "mΩ ( x10^-3 )",
            "µΩ ( x10^-6 )",
            "nΩ ( x10^-9 )",
            "pΩ ( x10^-12 )"});
      this.CBOhmsExp.Location = new System.Drawing.Point(149, 16);
      this.CBOhmsExp.Name = "CBOhmsExp";
      this.CBOhmsExp.Size = new System.Drawing.Size(121, 24);
      this.CBOhmsExp.TabIndex = 17;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.BAgregar);
      this.panel1.Location = new System.Drawing.Point(-6, 46);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(292, 70);
      this.panel1.TabIndex = 21;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(155, 19);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(121, 32);
      this.button1.TabIndex = 20;
      this.button1.Text = "Cancelar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(286, 112);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.NUDValor);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.CBOhmsExp);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "Form2";
      this.Text = "Editar";
      ((System.ComponentModel.ISupportInitialize)(this.NUDValor)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown NUDValor;
    private System.Windows.Forms.Button BAgregar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox CBOhmsExp;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
  }
}