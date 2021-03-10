using DevExpress.Mvvm;
using CountriesDB.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_1_7 {
  public class ViewModel : ViewModelBase {
    public ViewModel() {
      if (!IsInDesignMode) {
        DbContext = new CountriesDBContext();
        DbContext.Countries.Load();
        Countries = DbContext.Countries.Local;
      }
      else {
        Countries = new List<Country>();
      }
    }

    public CountriesDBContext DbContext { get; private set; }
    public IList<Country> Countries { get; private set; }
  }
}
