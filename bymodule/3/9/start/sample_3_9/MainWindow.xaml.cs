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
using System.IO;

namespace sample_3_9 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void PopupImageEditSettings_ConvertEditValue(DependencyObject sender, DevExpress.Xpf.Editors.ConvertEditValueEventArgs args) {
      if (args.ImageSource is BitmapSource source) {
        using (var stream = new MemoryStream()) {
          var encoder = new JpegBitmapEncoder();
          encoder.Frames.Add(BitmapFrame.Create(source));
          encoder.Save(stream);
          args.EditValue = stream.ToArray();
          args.Handled = true;
        }
      }
    }

    private void TableView_RowUpdated(object sender, DevExpress.Xpf.Grid.RowEventArgs e) {
      if (DataContext is ViewModel model)
        model.DbContext.SaveChanges();
    }
  }
}
