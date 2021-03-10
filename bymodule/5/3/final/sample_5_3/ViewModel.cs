using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_5_3 {
  public class ViewModel {
    public CountryInfoList Countries { get; } = new CountryInfoList();
    public int Count => Countries.Count();
    public double ScaleMax => Count * 1.2;
  }
}
