using System;
using System.ComponentModel;

public class CountryInfo : INotifyPropertyChanged {
  public CountryInfo() { }
  public CountryInfo(string name, int areaKM2, int population) {
    this.name = name;
    this.areaKM2 = areaKM2;
    this.population = population;
  }

  private string name;
  public string Name {
    get { return name; }
    set {
      if (name == value)
        return;
      name = value;
      OnPropertyChanged("Name");
    }
  }

  private int areaKM2;
  public int AreaKM2 {
    get { return areaKM2; }
    set {
      if (areaKM2 == value)
        return;
      areaKM2 = value;
      OnPropertyChanged("AreaKM2");
    }
  }

  private int population;
  public int Population {
    get { return population; }
    set {
      if (population == value)
        return;
      population = value;
      OnPropertyChanged("Population");
    }
  }


  public override string ToString() {
    return String.Format("Country: {0}, Area km^2: {1}, Population: {2}",
      Name, AreaKM2, Population);
  }

  public event PropertyChangedEventHandler PropertyChanged;

  protected virtual void OnPropertyChanged(string propertyName) {
    var handler = PropertyChanged;
    if (handler != null)
      handler(this, new PropertyChangedEventArgs(propertyName));
  }
}