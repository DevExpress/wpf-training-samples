using DevExpress.Mvvm;
using EventsDB.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_3_12 {
  public class ViewModel : ViewModelBase {
    public ViewModel() {
      if (!IsInDesignMode) {
        DbContext = new EventsDBContext();
        DbContext.Venues.Load();
        Venues = DbContext.Venues.Local;
      }
      else {
        Venues = new List<Venue>();
      }
    }

    public EventsDBContext DbContext { get; private set; }
    public IList<Venue> Venues { get; private set; }
  }
}
