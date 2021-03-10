using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Core;
using EventsDB.EF.Populate;

namespace sample_3_9 {
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
