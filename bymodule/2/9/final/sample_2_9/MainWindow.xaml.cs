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
using DevExpress.Xpf.RichEdit;

namespace sample_2_9 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : ThemedWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void RibbonGalleryBarItem_DropDownGalleryInit(object sender, DevExpress.Xpf.Ribbon.DropDownGalleryEventArgs e) {
      // e.DropDownGallery.Gallery.Groups....
    }

    private void RichEditControl_SelectionChanged(object sender, EventArgs e) {
      var edit = sender as RichEditControl;
      richEditContextCategory.IsVisible = !String.IsNullOrEmpty(edit.Selection);
    }
  }
}
