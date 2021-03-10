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
using DevExpress.XtraReports.UI;

namespace sample_6_7 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void ThemedWindow_Loaded(object sender, RoutedEventArgs e) {
      var report = new CountriesReport();
      ShowReportInPreview(report, false);

      designer.ReportStorage = new SaveToPreviewStorage(ShowReportInPreview);
      designer.OpenDocument(CloneReport(report));
    }

    void ShowReportInPreview(XtraReport report, bool clone = true) {
      var previewReport = clone ? CloneReport(report) : report;
      preview.DocumentSource = previewReport;
      previewReport.CreateDocument(true);
    }

    private XtraReport CloneReport(XtraReport report) {
      using (var ms = new MemoryStream()) {
        report.SaveLayoutToXml(ms);
        ms.Seek(0, SeekOrigin.Begin);
        return XtraReport.FromStream(ms, true);
      }
    }
  }
}
