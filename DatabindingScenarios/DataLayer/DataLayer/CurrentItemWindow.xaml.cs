using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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
using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.DataSources;

namespace DataLayer {
  /// <summary>
  /// Interaction logic for CurrentItemWindow.xaml
  /// </summary>
  public partial class CurrentItemWindow : DevExpress.Xpf.Core.ThemedWindow {
    public CurrentItemWindow() {
      InitializeComponent();
    }
  }

  public class CurrentItemViewModel : ViewModelBase {
    public CurrentItemViewModel() {
      if (!IsInDesignMode) {
        var context = new CountriesDBContext();
        context.Countries.Load();
        Countries = CollectionViewSource.GetDefaultView(context.Countries.Local);
      }
    }

    public ICollectionView Countries { get; private set; }
  }
}
