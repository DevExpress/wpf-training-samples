using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace sample_1_5 {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application {
    protected override void OnStartup(StartupEventArgs e) {
/*      DevExpress.Xpf.Core.ApplicationThemeHelper.ApplicationThemeName =
        DevExpress.Xpf.Core.Theme.Office2019ColorfulName;*/
      base.OnStartup(e);
    }
  }
}
