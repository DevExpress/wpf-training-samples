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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;

namespace sample_6_3 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void printGridButton_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
      var link = new PrintableControlLink((TableView)grid.View);
      PrintHelper.ShowRibbonPrintPreviewDialog(this, link);
    }
  }
}
