using DevExpress.Mvvm;
using EventsDB.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_4_4 {
  public class ViewModel : ViewModelBase {
    public ViewModel() {
      if (!IsInDesignMode) {
        DbContext = new EventsDBContext();
        DbContext.Events.Load();
        Events = DbContext.Events.Local;
      }
      else {
        Events = new List<Event>();
      }
    }

    public EventsDBContext DbContext { get; private set; }
    public IList<Event> Events { get; private set; }
  }
}
