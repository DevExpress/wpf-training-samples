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
using DevExpress.Spreadsheet;
using DevExpress.Xpf.Core;

namespace sample_5_14 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : ThemedWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void ThemedWindow_Loaded(object sender, RoutedEventArgs e) {
      var sheet = spreadsheet.Document.Worksheets[0];

      sheet.Cells["A10"].Value = "An initial value";

      sheet.Cells["A1"].Value = 1;
      sheet.Cells["A2"].Value = 2;
      sheet.Cells["A3"].Value = 3;
      sheet.Cells["A4"].Value = 4;
      sheet.Cells["A6"].Formula = "=SUM(A1:A4)";

      var customStyle = spreadsheet.Document.Styles.Add("custom");
      customStyle.Font.Size = 18;
      customStyle.Font.Bold = true;
      sheet.Cells["A6"].Style = customStyle;

      var chart = sheet.Charts.Add(DevExpress.Spreadsheet.Charts.ChartType.BarClustered, sheet.Range.Parse("A1:A4"));
      chart.Width = 1000;
      chart.Height = 800;
      chart.Move(50, 600);
    }

    private void createSampleData_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
      var sheet = spreadsheet.Document.Sheets.ActiveSheet;
      if (sheet is Worksheet worksheet) {
        var cell = worksheet.GetSelectedRanges()[0].First();
        cell.Value = "Test data";
        worksheet.Cells[cell.RowIndex + 1, cell.ColumnIndex].Value = "More test data here";
      }
    }
  }
}
