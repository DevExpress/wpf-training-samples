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
using DevExpress.Xpf.Scheduling.iCalendar;
using Microsoft.Win32;

namespace sample_4_3 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : ThemedWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void BarButtonItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
      var ofd = new OpenFileDialog() { Filter = "iCal Files (*.ics)|*.ics|All files (*.*)|*.*" };

      if (ofd.ShowDialog() == true) {
        var importer = new ICalendarImporter(scheduler);
        using (var stream = File.OpenRead(ofd.FileName)) {
          if (stream != null)
            importer.Import(stream);
        }
      }
    }
  }
}
