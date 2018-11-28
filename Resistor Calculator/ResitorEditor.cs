using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resistor_Calculator {
  public partial class ResitorEditor : Form {

    private bool Acept;
    public ResitorEditor(ref Resistor R) {
      Acept = false;
      InitializeComponent();
      CBOhmsExp.SelectedIndex = R.Op;
      NUDValor.Value = Convert.ToDecimal(R.Value);
    }

    private void BAgregar_Click(object sender, EventArgs e) {
      Acept = true;
      this.Close();
    }

    public List<Object> getDatas() {
      ShowDialog();

      Resistor R = new Resistor(Convert.ToDouble(NUDValor.Value), getExp(ref CBOhmsExp) ,CBOhmsExp.SelectedIndex);
      List<Object> Lis = new List<Object>();
      Lis.Add(Acept);
      Lis.Add(R);

      return Lis;
    }
    private int getExp(ref ComboBox CB) {
      switch (CB.SelectedIndex) {

        case 0:
          return 6;
        case 1:
          return 3;
        case 2:
          return 0;
        case 3:
          return -3;
        case 4:
          return -6;
        case 5:
          return -9;
        case 6:
          return -12;
      }
      return 0;
    }

    private void button1_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
