using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using CountriesDB.EF.Populate;
using DevExpress.Xpf.Core;

namespace sample_6_6 {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application {
    protected override void OnStartup(StartupEventArgs e) {
      base.OnStartup(e);

      DemoDatabase.Populate();
    }
  }
}
