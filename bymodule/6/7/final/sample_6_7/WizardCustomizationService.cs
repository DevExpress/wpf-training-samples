using DevExpress.DataAccess.EntityFramework;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.Entity.ProjectModel;
using DevExpress.Xpf.DataAccess.DataSourceWizard;
using DevExpress.Xpf.Reports.UserDesigner.ReportWizard;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Wizards;
using DevExpress.XtraReports.Wizards.Presenters;
using DevExpress.XtraReports.Wizards.Views;
using System;
using CountriesDB.EF;

namespace sample_6_7 {
  public class WizardCustomizationService : DevExpress.Xpf.Reports.UserDesigner.ReportWizard.IWizardCustomizationService {
    public void CustomizeDataSourceWizard(DataSourceWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) { }

    public void CustomizeReportWizard(ReportWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) {
      container.RegisterType<ChooseReportTypePage<XtraReportModel>, CustomChooseReportTypePage>();
    }

    public bool TryCreateDataSource(IDataSourceModel model, out object dataSource, out string dataMember) {
      dataSource = null;
      dataMember = null;
      return false;
    }

    public bool TryCreateReport(XtraReportModel model, out XtraReport report) {
      report = null;
      return false;
    }
  }


  public class CustomChooseReportTypePage : ChooseReportTypePage<XtraReportModel> {
    public CustomChooseReportTypePage(IChooseReportTypePageView view, IConnectionStorageService connectionStorageService, DataSourceTypes dataSourceTypes, IWizardRunnerContext context, ISolutionTypesProvider solutionTypesProvider) : base(view, connectionStorageService, dataSourceTypes, context, solutionTypesProvider) { }

    public override void Commit() {
      base.Commit();

      var connectionParameters = new EFConnectionParameters() {
        Source = typeof(CountriesDBContext)
      };
      var connection = new EFDataConnection("Countries", connectionParameters) {
        SolutionTypesProvider = SolutionTypesProvider
      };

      try {
        WaitFormActivator.ShowWaitForm(false, false, true);
        connection.Open();
      }
      catch (Exception e) {
        ExceptionHandler.HandleException(e);
      }
      finally {
        WaitFormActivator.CloseWaitForm();
      }

      Model.DataSourceType = DataSourceType.Entity;
      Model.DataConnection = connection;
    }

    public override Type GetNextPageType() {
      return typeof(ConfigureEFFiltersPage<XtraReportModel>);
    }
  }
}
