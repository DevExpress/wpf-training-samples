﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_5_6 {
  public class ViewModel {
    public CountryInfoList Countries { get; } = new CountryInfoList();
    public IEnumerable<CountryInfo> TopTenByPopulation => Countries.OrderByDescending(ci => ci.Population).Take(10);

    public Measurements Measurements { get; } = new Measurements();
  }
}
