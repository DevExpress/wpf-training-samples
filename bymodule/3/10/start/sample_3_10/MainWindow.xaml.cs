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
using DevExpress.Xpf.Core.DataSources;
using EventsDB.EF;
using System.Data.Entity;

namespace sample_3_10 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void PopupImageEditSettings_ConvertEditValue(DependencyObject sender, DevExpress.Xpf.Editors.ConvertEditValueEventArgs args) {
      var image = args.ImageSource as BitmapImage;
      if (image != null) {
        var stream = image.StreamSource;
        var imageBytes = new byte[stream.Length];
        stream.Position = 0;
        stream.Read(imageBytes, 0, imageBytes.Length);
        args.EditValue = imageBytes;
        args.Handled = true;
      }
    }

    private void TableView_RowUpdated(object sender, DevExpress.Xpf.Grid.RowEventArgs e) {
      if (DataContext is ViewModel model)
        model.DbContext.SaveChanges();
    }
  }
}
