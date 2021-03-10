using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using CountriesDB.EF.Populate;
using DevExpress.Xpf.Core;

namespace sample_1_7 {
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application {
    protected override void OnStartup(StartupEventArgs e) {
      base.OnStartup(e);

      DemoDatabase.Populate();

      Theme.RegisterPredefinedPaletteThemes();

      foreach (var theme in Theme.Themes.ToList()) {
        if (theme.Category != Theme.Office2019Category)
          theme.ShowInThemeSelector = false;
      }
    }

    protected override void OnExit(ExitEventArgs e) {
      ApplicationThemeHelper.SaveApplicationThemeName();

      base.OnExit(e);
    }
  }
}
