namespace sample_6_7 {
  partial class CountriesReport {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      DevExpress.DataAccess.EntityFramework.EFConnectionParameters efConnectionParameters1 = new DevExpress.DataAccess.EntityFramework.EFConnectionParameters();
      DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
      this.efDataSource1 = new DevExpress.DataAccess.EntityFramework.EFDataSource(this.components);
      this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
      this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
      this.label1 = new DevExpress.XtraReports.UI.XRLabel();
      this.Detail = new DevExpress.XtraReports.UI.DetailBand();
      this.table2 = new DevExpress.XtraReports.UI.XRTable();
      this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
      this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
      this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
      this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
      this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
      this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
      this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
      this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
      this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
      this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
      this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
      this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
      this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
      this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
      this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
      this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
      this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
      this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
      ((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // efDataSource1
      // 
      efConnectionParameters1.ConnectionString = "";
      efConnectionParameters1.ConnectionStringName = "";
      efConnectionParameters1.Source = typeof(CountriesDB.EF.CountriesDBContext);
      this.efDataSource1.ConnectionParameters = efConnectionParameters1;
      this.efDataSource1.Name = "efDataSource1";
      // 
      // Title
      // 
      this.Title.BackColor = System.Drawing.Color.Transparent;
      this.Title.BorderColor = System.Drawing.Color.Black;
      this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.Title.BorderWidth = 1F;
      this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
      this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
      this.Title.Name = "Title";
      // 
      // DetailCaption1
      // 
      this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
      this.DetailCaption1.BorderColor = System.Drawing.Color.White;
      this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
      this.DetailCaption1.BorderWidth = 2F;
      this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
      this.DetailCaption1.ForeColor = System.Drawing.Color.White;
      this.DetailCaption1.Name = "DetailCaption1";
      this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // DetailData1
      // 
      this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
      this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
      this.DetailData1.BorderWidth = 2F;
      this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
      this.DetailData1.ForeColor = System.Drawing.Color.Black;
      this.DetailData1.Name = "DetailData1";
      this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // DetailData3_Odd
      // 
      this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
      this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
      this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.DetailData3_Odd.BorderWidth = 1F;
      this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
      this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
      this.DetailData3_Odd.Name = "DetailData3_Odd";
      this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // PageInfo
      // 
      this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
      this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
      this.PageInfo.Name = "PageInfo";
      this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      // 
      // TopMargin
      // 
      this.TopMargin.Name = "TopMargin";
      // 
      // BottomMargin
      // 
      this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
      this.BottomMargin.Name = "BottomMargin";
      // 
      // pageInfo1
      // 
      this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
      this.pageInfo1.StyleName = "PageInfo";
      // 
      // pageInfo2
      // 
      this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Page {0} of {1}";
      // 
      // ReportHeader
      // 
      this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
      this.ReportHeader.HeightF = 60F;
      this.ReportHeader.Name = "ReportHeader";
      // 
      // label1
      // 
      this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
      this.label1.Name = "label1";
      this.label1.SizeF = new System.Drawing.SizeF(638F, 24.19433F);
      this.label1.StyleName = "Title";
      this.label1.Text = "Countries";
      // 
      // Detail
      // 
      this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
      this.Detail.HeightF = 25F;
      this.Detail.Name = "Detail";
      // 
      // table2
      // 
      this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
      this.table2.Name = "table2";
      this.table2.OddStyleName = "DetailData3_Odd";
      this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
      this.table2.SizeF = new System.Drawing.SizeF(650F, 25F);
      // 
      // tableRow2
      // 
      this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell2});
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 11.5D;
      // 
      // tableCell2
      // 
      this.tableCell2.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.tableCell2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
      this.tableCell2.Name = "tableCell2";
      this.tableCell2.StyleName = "DetailData1";
      this.tableCell2.StylePriority.UseBorders = false;
      this.tableCell2.StylePriority.UseFont = false;
      this.tableCell2.Text = "Region: [Name]";
      this.tableCell2.Weight = 1D;
      // 
      // DetailReport
      // 
      this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.DetailReport1});
      this.DetailReport.DataMember = "Regions.SubRegions";
      this.DetailReport.DataSource = this.efDataSource1;
      this.DetailReport.Level = 0;
      this.DetailReport.Name = "DetailReport";
      // 
      // Detail1
      // 
      this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.xrLabel1});
      this.Detail1.HeightF = 61.54165F;
      this.Detail1.Name = "Detail1";
      // 
      // xrTable1
      // 
      this.xrTable1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
      this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(21.875F, 36.54165F);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
      this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
      this.xrTable1.SizeF = new System.Drawing.SizeF(605.2083F, 25F);
      this.xrTable1.StylePriority.UseFont = false;
      // 
      // xrTableRow1
      // 
      this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell4,
            this.xrTableCell3});
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1D;
      // 
      // xrTableCell1
      // 
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.Text = "Flag";
      this.xrTableCell1.Weight = 0.58003442609840339D;
      // 
      // xrTableCell2
      // 
      this.xrTableCell2.Multiline = true;
      this.xrTableCell2.Name = "xrTableCell2";
      this.xrTableCell2.Text = "Country";
      this.xrTableCell2.Weight = 2.1566265953308745D;
      // 
      // xrTableCell4
      // 
      this.xrTableCell4.Multiline = true;
      this.xrTableCell4.Name = "xrTableCell4";
      this.xrTableCell4.Text = "Area";
      this.xrTableCell4.Weight = 0.63511189742603991D;
      // 
      // xrTableCell3
      // 
      this.xrTableCell3.Multiline = true;
      this.xrTableCell3.Name = "xrTableCell3";
      this.xrTableCell3.Text = "Population";
      this.xrTableCell3.Weight = 0.628227081144682D;
      // 
      // xrLabel1
      // 
      this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Name]")});
      this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(21.875F, 0F);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 23F);
      this.xrLabel1.Text = "xrLabel1";
      // 
      // DetailReport1
      // 
      this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.ReportFooter});
      this.DetailReport1.DataMember = "Regions.SubRegions.Countries";
      this.DetailReport1.DataSource = this.efDataSource1;
      this.DetailReport1.Level = 0;
      this.DetailReport1.Name = "DetailReport1";
      // 
      // Detail2
      // 
      this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
      this.Detail2.HeightF = 25F;
      this.Detail2.Name = "Detail2";
      // 
      // xrTable2
      // 
      this.xrTable2.Font = new System.Drawing.Font("Arial", 9.75F);
      this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(21.875F, 0F);
      this.xrTable2.Name = "xrTable2";
      this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
      this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
      this.xrTable2.SizeF = new System.Drawing.SizeF(605.2083F, 25F);
      this.xrTable2.StylePriority.UseFont = false;
      // 
      // xrTableRow2
      // 
      this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
      this.xrTableRow2.Name = "xrTableRow2";
      this.xrTableRow2.Weight = 1D;
      // 
      // xrTableCell5
      // 
      this.xrTableCell5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
      this.xrTableCell5.Multiline = true;
      this.xrTableCell5.Name = "xrTableCell5";
      this.xrTableCell5.Text = "Flag";
      this.xrTableCell5.Weight = 0.58003442609840339D;
      // 
      // xrPictureBox1
      // 
      this.xrPictureBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[FlagImage]")});
      this.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleLeft;
      this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
      this.xrPictureBox1.Name = "xrPictureBox1";
      this.xrPictureBox1.SizeF = new System.Drawing.SizeF(67.7604F, 25F);
      this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
      // 
      // xrTableCell6
      // 
      this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OfficialName]")});
      this.xrTableCell6.Font = new System.Drawing.Font("Arial", 9.75F);
      this.xrTableCell6.Multiline = true;
      this.xrTableCell6.Name = "xrTableCell6";
      this.xrTableCell6.StylePriority.UseFont = false;
      this.xrTableCell6.Text = "Country";
      this.xrTableCell6.Weight = 2.1566265953308745D;
      // 
      // xrTableCell7
      // 
      this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Area]")});
      this.xrTableCell7.Multiline = true;
      this.xrTableCell7.Name = "xrTableCell7";
      this.xrTableCell7.Text = "Area";
      this.xrTableCell7.Weight = 0.63511189742603991D;
      // 
      // xrTableCell8
      // 
      this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Population]")});
      this.xrTableCell8.Multiline = true;
      this.xrTableCell8.Name = "xrTableCell8";
      this.xrTableCell8.Text = "Population";
      this.xrTableCell8.Weight = 0.628227081144682D;
      // 
      // ReportFooter
      // 
      this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
      this.ReportFooter.Name = "ReportFooter";
      // 
      // xrTable3
      // 
      this.xrTable3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
      this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(218.7501F, 9.999974F);
      this.xrTable3.Name = "xrTable3";
      this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
      this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
      this.xrTable3.SizeF = new System.Drawing.SizeF(408.3333F, 25F);
      this.xrTable3.StylePriority.UseFont = false;
      // 
      // xrTableRow3
      // 
      this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell11});
      this.xrTableRow3.Name = "xrTableRow3";
      this.xrTableRow3.Weight = 1D;
      // 
      // xrTableCell10
      // 
      this.xrTableCell10.Multiline = true;
      this.xrTableCell10.Name = "xrTableCell10";
      this.xrTableCell10.Text = "Countries in sub-region \'[Regions.SubRegions.Name]\'";
      this.xrTableCell10.Weight = 3.08333251953125D;
      // 
      // xrTableCell11
      // 
      this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount()")});
      this.xrTableCell11.Multiline = true;
      this.xrTableCell11.Name = "xrTableCell11";
      this.xrTableCell11.StylePriority.UseTextAlignment = false;
      xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
      this.xrTableCell11.Summary = xrSummary1;
      this.xrTableCell11.Text = "xrTableCell11";
      this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
      this.xrTableCell11.Weight = 1D;
      // 
      // CountriesReport
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.Detail,
            this.DetailReport});
      this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.efDataSource1});
      this.DataMember = "Regions";
      this.DataSource = this.efDataSource1;
      this.Font = new System.Drawing.Font("Arial", 9.75F);
      this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
      this.Version = "20.1";
      ((System.ComponentModel.ISupportInitialize)(this.efDataSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.DataAccess.EntityFramework.EFDataSource efDataSource1;
    private DevExpress.XtraReports.UI.XRControlStyle Title;
    private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
    private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
    private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
    private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
    private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
    private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    private DevExpress.XtraReports.UI.XRLabel label1;
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.XRTable table2;
    private DevExpress.XtraReports.UI.XRTableRow tableRow2;
    private DevExpress.XtraReports.UI.XRTableCell tableCell2;
    private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
    private DevExpress.XtraReports.UI.DetailBand Detail1;
    private DevExpress.XtraReports.UI.XRTable xrTable1;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
    private DevExpress.XtraReports.UI.DetailBand Detail2;
    private DevExpress.XtraReports.UI.XRTable xrTable2;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
    private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
    private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
    private DevExpress.XtraReports.UI.XRTable xrTable3;
    private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
    private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
  }
}
