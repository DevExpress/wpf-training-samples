using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CountriesDB.EF;
using DevExpress.Xpf.Core;
using System.Data.Entity;
using DevExpress.Mvvm;

namespace DataLayer {
  /// <summary>
  /// Interaction logic for EFFromCodeWindow.xaml
  /// </summary>
  public partial class EFWindow : DevExpress.Xpf.Core.ThemedWindow {
    public EFWindow() {
      InitializeComponent();
    }
  }

  public class EFViewModel : ViewModelBase {
    public EFViewModel() {
      if (!IsInDesignMode) {
        var context = new CountriesDBContext();
        context.Countries.Load();
        Countries = context.Countries.Local;
      }
    }

    public IList<Country> Countries { get; private set; }
  }
}
