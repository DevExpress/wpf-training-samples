using DevExpress.Mvvm;
using SalesDB.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_5_9 {
  public class ViewModel : ViewModelBase {
    public ViewModel() {
      if (!IsInDesignMode) {
        DbContext = new SalesDBContext();
        DbContext.Sales.Load();
        Sales = DbContext.Sales.Local;     
      }
      else {
        Sales = new List<Sale>();
      }
    }

    public SalesDBContext DbContext { get; private set; }
    public IList<Sale> Sales { get; private set; }
  }
}
