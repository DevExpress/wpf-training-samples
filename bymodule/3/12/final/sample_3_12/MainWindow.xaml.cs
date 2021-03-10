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
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.Xpf.Grid;
using System.IO;

namespace sample_3_12 {
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

    private void capacityColumn_Validate(object sender, DevExpress.Xpf.Grid.GridCellValidationEventArgs e) {
      const int minPlausibleSize = 6;
      try {
        int currentValue = (int)e.Value;
        if (currentValue < minPlausibleSize) {
          e.IsValid = false;
          e.SetError("Capacity must be 6 or higher", ErrorType.Critical);
        }
        else
          e.IsValid = true;
      }
      catch (Exception) {
        e.IsValid = false;
        e.SetError("Invalid capacity value", ErrorType.Critical);
      }
    }

    private void bookingsView_ValidateRow(object sender, DevExpress.Xpf.Grid.GridRowValidationEventArgs e) {
      var booking = e.Row as RoomBooking;
      if (booking != null) {
        if (booking.StartTime >= booking.EndTime) {
          e.IsValid = false;
          e.SetError("The end time must be greater than the start time", ErrorType.Critical);
        }
      }
    }

    private void bookingsView_InvalidRowException(object sender, DevExpress.Xpf.Grid.InvalidRowExceptionEventArgs e) {
      e.ExceptionMode = ExceptionMode.NoAction;
    }
  }
}
