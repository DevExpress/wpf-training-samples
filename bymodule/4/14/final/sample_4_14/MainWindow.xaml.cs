using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Serialization;

namespace sample_4_14 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void ThemedWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
      //grid.SaveLayoutToXml("grid.xml");

      DXSerializer.Serialize(this, "controlsettings.xml", "LayoutPersistenceStart", null);
    }

    private void ThemedWindow_Loaded(object sender, RoutedEventArgs e) {
      //if (File.Exists("grid.xml"))
      //  grid.RestoreLayoutFromXml("grid.xml");

      if (File.Exists("controlsettings.xml"))
        DXSerializer.Deserialize(this, "controlsettings.xml", "LayoutPersistenceStart", null);
    }
  }
}
