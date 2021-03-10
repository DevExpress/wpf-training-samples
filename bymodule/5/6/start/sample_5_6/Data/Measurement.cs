using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Measurement {
  public Measurement(double phase, double impedance, double voltage) {
    this.Phase = phase;
    this.Impedance = impedance;
    this.Voltage = voltage;
  }

  public double Phase { get; set; }
  public double Impedance { get; set; }
  public double Voltage { get; set; }
}
