using System;
using System.Collections.Generic;
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
using DevExpress.Data.Linq;
using DevExpress.Mvvm;
using DevExpress.Xpf.Core;


namespace DataLayer {
  /// <summary>
  /// Interaction logic for EntityServerModeDataSourceWindow.xaml
  /// </summary>
  public partial class EntityServerModeSourceWindow : ThemedWindow {
    public EntityServerModeSourceWindow() {
      InitializeComponent();
    }
  }

  public class EntityServerModeViewModel : ViewModelBase {
    public EntityServerModeViewModel() {
      if (!IsInDesignMode) {
        var context = new CountriesDBContext();
        Countries = new EntityServerModeSource() { QueryableSource = context.Countries, KeyExpression = "Id" };
      }
    }

    public EntityServerModeSource Countries { get; private set;  }
  }
}
