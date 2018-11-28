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
  public partial class ResitorMainView : Form {
    
    private List<Resistor> Resistors;
    private Calculate c;
    private Calculate cP;
    public ResitorMainView() {

      InitializeComponent();
      InitializeComp2();
    }

    private void InitializeComp2() {

      Resistors = new List<Resistor>();

      CBOhmsExp.SelectedIndex = 2;

      CBVoltsExp.SelectedIndex = 2;

      CBMostRes.SelectedIndex = 2;

      CBAmpers.SelectedIndex = 2;

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

    private string getResults() {
      StringBuilder Results = new StringBuilder();
      if(CBResTot.Checked) {
        Results.Append(c.getResultResistenceT());
        Results.AppendLine("---------------------------------------------------");
        Results.AppendLine();
      }
      if(CBVoltage.Checked) {
        Results.Append(c.getResultVoltage());
        Results.AppendLine("---------------------------------------------------");
        Results.AppendLine();
      }
      if (CBIntensidad.Checked) {
        Results.Append(c.getResultItensity());
        Results.AppendLine("---------------------------------------------------");
        Results.AppendLine();
      }
      if (CBVoltsXRes.Checked) {
        Results.Append(c.getResultsVoltages());
        Results.AppendLine("---------------------------------------------------");
        Results.AppendLine();
      }
      if (CBPot.Checked) {
        Results.Append(c.getResultsPotences());
        Results.AppendLine("---------------------------------------------------");
        Results.AppendLine();
      }

      return Results.ToString();
    }

    private void BAgregar_Click(object sender, EventArgs e) {

      Resistor r = new Resistor(Convert.ToDouble(NUDValor.Value), getExp(ref CBOhmsExp), CBOhmsExp.SelectedIndex);
      Resistors.Add(r);
      DGVResistencias.Rows.Add("" + Resistors.Count, r.ToString());
    }

    private void BCalcular_Click(object sender, EventArgs e) {

      if (Resistors.Count != 0) {

        if (RBVoltaje.Checked) {
          c = new Calculate(ref Resistors, Convert.ToDouble(NUDVoltaje.Value),
         getExp(ref CBVoltsExp), getExp(ref CBMostRes));

        }
        if (RBAmpers.Checked) {
          c = new Calculate(ref Resistors, getExp(ref CBAmpers), 
            Convert.ToDouble(NUDAmpers.Value), getExp(ref CBMostRes));
        }
       
        TBResults.Text = getResults();
      } else {
        MessageBox.Show(this, "No hay datos en la tabla.");
      }
    }

    private void BEliminar_Click(object sender, EventArgs e) {

      if (Resistors.Count != 0) {

        DialogResult result = MessageBox.Show("¿Estas seguro de borrar?", "Alerta", MessageBoxButtons.YesNo);
        if(result == DialogResult.Yes) {

          DataGridViewSelectedRowCollection r = DGVResistencias.SelectedRows;
          foreach (DataGridViewRow t in r) {
            Resistors.RemoveAt(t.Index);
            DGVResistencias.Rows.RemoveAt(t.Index);
          }
          int i = 1;
          foreach (DataGridViewRow dgvRow in DGVResistencias.Rows) {
            dgvRow.Cells[0].Value ="" + i++;
          }
        }

      } else {
        MessageBox.Show("No hay datos en la tabla.");
      }
    }

    private void BLimpiar_Click(object sender, EventArgs e) {
      if (Resistors.Count != 0) {

        DialogResult result = MessageBox.Show("¿Estas seguro de borrar todos los datos?", "Alerta", MessageBoxButtons.YesNo);
     
        if (result == DialogResult.Yes) {

          DGVResistencias.SelectAll();
          DataGridViewSelectedRowCollection r = DGVResistencias.SelectedRows;
          foreach (DataGridViewRow t in r) {
            Resistors.RemoveAt(t.Index);
            DGVResistencias.Rows.RemoveAt(t.Index);
          }
        } else {

          MessageBox.Show("No hay datos en la tabla.");
        }
      }
    }
       
    private void BEditar_Click(object sender, EventArgs e) {

      if (Resistors.Count != 0) {
        int index = DGVResistencias.SelectedRows[0].Index;
        Resistor Res = Resistors[index];
        ResitorEditor f2 = new ResitorEditor(ref Res);
        List<Object> prop = f2.getDatas();
        if((bool)prop[0]) {
          Resistors[index] = (Resistor)prop[1];
          DGVResistencias.SelectedRows[0].Cells[1].Value = Resistors[index].valueToString();
        } 
        
      } else {

        MessageBox.Show("No hay datos en la tabla.");
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {

      bool check = checkBox1.Checked;
      CBPot.Checked = check;
      CBVoltsXRes.Checked = check;
      CBResTot.Checked = check;

      if(CBIntensidad.Enabled)
        CBIntensidad.Checked = check;

      if(CBVoltage.Enabled)
        CBVoltage.Checked = check;
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e) {
      NUDAmpers.Enabled = false;
      CBAmpers.Enabled = false;
      NUDVoltaje.Enabled = true;
      CBVoltsExp.Enabled = true;
      CBIntensidad.Enabled = true;
      CBIntensidad.Checked = true;
      CBVoltage.Checked = false;
      CBVoltage.Enabled = false;

    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e) {
      NUDAmpers.Enabled = true;
      CBAmpers.Enabled = true;
      NUDVoltaje.Enabled = false;
      CBVoltsExp.Enabled = false;
      CBIntensidad.Enabled = false;
      CBIntensidad.Checked = false;
      CBVoltage.Enabled = true;
      CBVoltage.Checked = true;

    }
  }
}
