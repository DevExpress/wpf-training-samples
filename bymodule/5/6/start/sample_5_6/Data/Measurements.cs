using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Measurements : ObservableCollection<Measurement> {
  public Measurements() {
    Add(new Measurement(-60, 2, 10));
    Add(new Measurement(-40, 2, 15));
    Add(new Measurement(-20, 2, 25));
    Add(new Measurement(0, 2, 28));
    Add(new Measurement(20, 2, 21));
    Add(new Measurement(40, 2, 16));
    Add(new Measurement(60, 2, 9));

    Add(new Measurement(-60, 3, 15));
    Add(new Measurement(-40, 3, 19));
    Add(new Measurement(-20, 3, 29));
    Add(new Measurement(0, 3, 30));
    Add(new Measurement(20, 3, 29));
    Add(new Measurement(40, 3, 21));
    Add(new Measurement(60, 3, 15));

    Add(new Measurement(-60, 4, 23));
    Add(new Measurement(-40, 4, 28));
    Add(new Measurement(-20, 4, 33));
    Add(new Measurement(0, 4, 33));
    Add(new Measurement(20, 4, 33));
    Add(new Measurement(40, 4, 29));
    Add(new Measurement(60, 4, 23));

    Add(new Measurement(-60, 6, 30));
    Add(new Measurement(-40, 6, 35));
    Add(new Measurement(-20, 6, 35));
    Add(new Measurement(0, 6, 35));
    Add(new Measurement(20, 6, 35));
    Add(new Measurement(40, 6, 35));
    Add(new Measurement(60, 6, 33));

    Add(new Measurement(-60, 8, 35));
    Add(new Measurement(-40, 8, 35));
    Add(new Measurement(-20, 8, 35));
    Add(new Measurement(0, 8, 35));
    Add(new Measurement(20, 8, 35));
    Add(new Measurement(40, 8, 35));
    Add(new Measurement(60, 8, 35));
  }

  // Helpers to calculate coordinates for "curtains" of the surface

  public double FrontLineImpedance => Impedances.Min();
  public List<double> FrontLine => new List<double>() { FrontLineImpedance, FrontLineImpedance };
  public List<double> Phases => this.Select(m => m.Phase).Distinct().ToList();
  public List<double> FrontCurtainValues {
    get {
      var values = this.Where(m => m.Impedance == FrontLineImpedance).Select(m => m.Voltage);
      return values.Concat(Enumerable.Repeat<double>(0, values.Count())).ToList();
    }
  }
  public List<double> Impedances => this.Select(m => m.Impedance).Distinct().ToList();
  public double RightLinePhase => Phases.Max();
  public List<double> RightLine => new List<double>() { RightLinePhase, RightLinePhase };
  public List<double> RightCurtainValues {
    get {
      var values = this.Where(m => m.Phase == RightLinePhase).Select(m => m.Voltage);
      return Enumerable.Repeat<double>(0, values.Count()).Zip(values, (a, b) => new List<double> { a, b }).SelectMany(x => x).ToList();
    }
  }
}
