using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistor_Calculator {
  class Calculate {

    private List<Resistor> Resistors;
    private StringBuilder ResultsVoltages, ResultsPotences, ResultItensity, ResultResistenceT, ResultVoltage;// ResultComprueba;
    private double intensity, resTot, voltage, divFormat;
    private string sExp;
    private int exp, formatS;

    public Calculate(ref List<Resistor> Resistors, double voltage, int exp, int formatS) {

      this.Resistors = Resistors;
      this.exp = exp;
      this.voltage = voltage * Math.Pow(10,exp);
      this.formatS = formatS;
      generateExp(formatS);
      calculeResistenceTot();
      calculeIntensity();
      calculateVoltages(ref Resistors);
      calculatePotences(ref Resistors);
      //Comprueba();
    }

    public Calculate(ref List<Resistor> Resistors, int exp, double intensity, int formatS) {

      this.Resistors = Resistors;
      this.exp = exp;
      this.intensity = intensity;
      this.formatS = formatS;
      generateExp(formatS);
      calculeResistenceTot();
      calculateVoltage();
      calculateVoltages(ref Resistors);
      calculatePotences(ref Resistors);
    }

    private void calculeResistenceTot() {

      ResultResistenceT = new StringBuilder();
      ResultResistenceT.AppendLine("Resistencia Total");
      ResultResistenceT.AppendLine("---------------------------------------------------");
      ResultResistenceT.Append("RT = ");
      foreach (Resistor R in Resistors) {
        resTot += R.ValueEx;
        ResultResistenceT.Append( (R!=Resistors[0]?" + ":"") + R.valueToString());
      }
      //CAMBIAR FORMATO
      double res = resTot / divFormat;
      ResultResistenceT.AppendFormat(" = {0} {1}Ω ", Math.Round(res,3), sExp);
      ResultResistenceT.AppendLine();
    }

    private void calculeIntensity() {

      intensity = voltage / resTot;

      ResultItensity = new StringBuilder();
      ResultItensity.AppendLine("Intensidad");
      ResultItensity.AppendLine("---------------------------------------------------");

      double inte = intensity / divFormat;
      ResultItensity.AppendFormat("I = {0} V / {2} Ω = {3} {1} A", Math.Round(voltage, 3), sExp, 
        Math.Round(resTot, 3), Math.Round(inte, 3));
      ResultItensity.AppendLine();
    }

    private void calculateVoltage() {

      voltage = (intensity * Math.Pow(10, exp)) * this.resTot;

      ResultVoltage = new StringBuilder();
      ResultVoltage.AppendLine("Voltaje");
      ResultVoltage.AppendLine("---------------------------------------------------");

      double volt = voltage / divFormat;
      ResultVoltage.AppendFormat("V = {0} A * {2} Ω = {3} {1} V", Math.Round(intensity, 3), sExp,
        Math.Round(resTot, 3), Math.Round(volt, 3));
      ResultVoltage.AppendLine();
    }

    private void calculateVoltages(ref List<Resistor> Res) {

      int i = 1;

      ResultsVoltages = new StringBuilder();
      ResultsVoltages.AppendLine("Voltajes por Resistencia");
      ResultsVoltages.AppendLine("---------------------------------------------------");

      foreach (Resistor R in Res) {

        R.Voltage = intensity * R.Value;
        double Volt = R.Voltage / divFormat;
        ResultsVoltages.AppendFormat("V{0} = ( {1} A ) ( {2} Ω ) = {3} {4}V\r\n", i++, Math.Round(intensity, 3),
          Math.Round(R.Value, 3), Math.Round(Volt, 3), sExp);
       
      }
    }

    private void calculatePotences(ref List<Resistor> Res) {

      int i = 1;

      ResultsPotences = new StringBuilder();
      ResultsPotences.AppendLine("Potencias por Resistencia");
      ResultsPotences.AppendLine("---------------------------------------------------");

      foreach (Resistor R in Res) {
        R.Potence = Math.Pow(intensity,2) * R.Value;
        double Pot = R.Potence / divFormat;
        ResultsPotences.AppendFormat("P{0} = ( {1} ^2 A ) ( {2} Ω) = {3} {4}W\r\n", i++, Math.Round(intensity,3),
          Math.Round(R.Value, 3), Math.Round(Pot, 3), sExp);
      }
    }

    /*private void Comprueba() {



      ResultComprueba = new StringBuilder();
      ResultComprueba.AppendLine("Comprobaciones");
      ResultComprueba.AppendLine("---------------------------------------------------");
      ResultComprueba.AppendLine("Potencia:");

      double sumaPot = 0;
      foreach (Resistor R in Resistors) {
        sumaPot += R.Potence;
        ResultsPotences.AppendFormat("P{0} = ( {1} ^2 A ) ( {2} Ω) = {3} {4}W\r\n", i++, intensity, R.Value, Pot, sExp);
      }

    }*/

    private void generateExp(int ex) {

      switch (ex) {

        case 6:
          sExp = "M";
          divFormat = 1000000;
          break;
        case 3:
          sExp = "k";
          divFormat = 1000;
          break;
        case 0:
          sExp = "";
          divFormat = 1;
          break;
        case -3:
          sExp = "m";
          divFormat = 0.0001;
          break;
        case -6:
          sExp = "µ";
          divFormat = 0.0000001;
          break;
        case -9:
          sExp = "n";
          divFormat = 0.0000000001;
          break;
        case -12:
          sExp = "p";
          divFormat = 0.0000000000001;
          break;
      }
    }

    public string getResultsVoltages() {

      return ResultsVoltages.ToString();
    }

    public string getResultItensity() {

      return ResultItensity.ToString();
    }

    public string getResultsPotences() {

      return ResultsPotences.ToString();
    }

    public string getResultResistenceT() {

      return ResultResistenceT.ToString();
    }
    
    public string getResultVoltage() {

      return ResultVoltage.ToString();
    }

  }
}
