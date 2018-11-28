using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistor_Calculator {
  public class Resistor {

    private double value, valueEx;
    private string sExp;
    private double Volt, Pot;
    private int exp, op;
    

    public Resistor(double value, int exp, int op) {
      this.value = value;
      this.exp = exp;
      this.op = op;
      this.valueEx = value * Math.Pow(10, exp);
      generateExp();
    }

    public Resistor(double value) {
      this.valueEx = value;
      this.value = valueEx;
      exp = 0;
      generateExp();
    }

    public string valueToString() {

      StringBuilder MyStringBuilder = new StringBuilder();
      MyStringBuilder.AppendFormat("{0} {1}", value, sExp);
      return MyStringBuilder.ToString();
    }

    public override string ToString() {

      StringBuilder MyStringBuilder = new StringBuilder();
      MyStringBuilder.AppendFormat("{0} {1}",  value, sExp);
      return MyStringBuilder.ToString();
    }

    private void generateExp() {
      
      switch(exp) {

        case 6:
          sExp = "MΩ";
          break;
        case 3:
          sExp = "kΩ";
          break;
        case 0:
          sExp = "Ω";
          break;
        case -3:
          sExp = "mΩ";
          break;
        case -6:
          sExp = "µΩ";
          break;
        case -9:
          sExp = "nΩ";
          break;
        case -12:
          sExp = "pΩ";
          break;
      }
    }

    public int Exp {
      set {
        exp = value;
        this.valueEx = value * Math.Pow(10, exp);
        generateExp();
      }

      get {

        return exp;
      }
    }

    public double Voltage {
      get {
        return Volt;
      }
      set {
        Volt = value;
      }
    }

    public double Potence {
      get {
        return Pot;
      }
      set {
        Pot = value;
      }
    }

    public double Value {
      get {
        return value;
      }
      set {
        this.value = value;
        valueEx = value * Math.Pow(10, exp);
      }
    }

    public double ValueEx {
      get {
        return valueEx;
      }
      set {
        this.valueEx = value;
      }
    }

    public int Op {
      set {
        op = value;
      }
      get {
        return op;
      }
    }
  }
}
