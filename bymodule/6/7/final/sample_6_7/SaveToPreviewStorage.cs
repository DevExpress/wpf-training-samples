using DevExpress.Xpf.Reports.UserDesigner;
using DevExpress.XtraReports.UI;
using System;

namespace sample_6_7 {
  public class SaveToPreviewStorage : IReportStorage {
    public delegate void ShowInPreviewAction(XtraReport report, bool clone = true);
    public SaveToPreviewStorage(ShowInPreviewAction replacePreviewReport) => this.replacePreviewReport = replacePreviewReport;
    private readonly ShowInPreviewAction replacePreviewReport;

    public bool CanCreateNew() => true;
    public bool CanOpen() => false;
    public XtraReport CreateNew() => new XtraReport();
    public XtraReport CreateNewSubreport() => new XtraReport();
    public string GetErrorMessage(Exception exception) => exception.Message;
    public XtraReport Load(string reportID, IReportSerializer designerReportSerializer) => null;
    public string Open(IReportDesignerUI designer) => null;

    public string Save(string reportID, IReportProvider reportProvider, bool saveAs, string reportTitle, IReportDesignerUI designer) {
      var editedReport = reportProvider.GetReport();
      replacePreviewReport(editedReport);
      return reportID;
    }
  }
}