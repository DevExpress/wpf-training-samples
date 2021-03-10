using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DataLayer {
  /// <summary>
  /// Interaction logic for AsyncSourceWindow.xaml
  /// </summary>
  public partial class VirtualSourceWindow : ThemedWindow {
    public VirtualSourceWindow() {
      InitializeComponent();
    }
  }

  public class ViewModel {
    public ViewModel() {
      Source = new PagedAsyncSource() {
        ElementType = typeof(CountryInfo),
        PageNavigationMode = PageNavigationMode.ArbitraryWithTotalPageCount
      };

      Source.FetchPage += (o, e) => {
        e.Result = FetchRows(e);
      };

      Source.GetTotalSummaries += (o, e) => {
        e.Result = GetTotalSummaries(e);
      };
    }

    public PagedAsyncSource Source { get; private set; }

    async Task<FetchRowsResult> FetchRows(FetchPageAsyncEventArgs e) {
      var parameters = CreateParameters();
      parameters["skip"] = e.Skip.ToString();
      parameters["take"] = e.Take.ToString();
      parameters["requireTotalCount"] = "false";
      var sortInfo = e.SortOrder.Select(so => new SortInfo {
        Selector = GetFieldName(so.PropertyName),
        Desc = so.Direction == ListSortDirection.Descending
      }).ToArray();
      parameters["sort"] = JsonConvert.SerializeObject(sortInfo);
      var result = await GetFetchResult(dataUrl, parameters);
      return new FetchRowsResult(result.Data, hasMoreRows: result.Data.Length == e.Take);
    }

    async Task<object[]> GetTotalSummaries(GetSummariesAsyncEventArgs e) {
      var parameters = CreateParameters();
      parameters["take"] = "1";
      parameters["requireTotalCount"] = "false";
      var summaryInfo = e.Summaries.Select(s => new SummaryInfo {
        Selector = GetFieldName(s.PropertyName),
        SummaryType = s.SummaryType.ToString().ToLower()
      }).ToArray();
      parameters["totalSummary"] = JsonConvert.SerializeObject(summaryInfo);
      var result = await GetFetchResult(dataUrl, parameters);
      return result.Summary.Cast<object>().ToArray();
    }

    readonly HttpClient httpClient = new HttpClient();
    readonly string dataUrl = "http://outlier.oliversturm.com:8080/countries";

    NameValueCollection CreateParameters() => HttpUtility.ParseQueryString("");

    async Task<FetchResult> GetFetchResult(string uri, NameValueCollection parameters) {
      var uriBuilder = new UriBuilder(uri);
      uriBuilder.Query = parameters.ToString();
      var response = await httpClient.GetAsync(uriBuilder.Uri);
      string json = await response.Content.ReadAsStringAsync();
      return JsonConvert.DeserializeObject<FetchResult>(json);
    }

    Dictionary<string, string> fieldMappings = new Dictionary<string, string> {
      {"Name", "name" },
      {"AreaKM2", "areaKM2" },
      {"Population","population" }
    };

    string GetFieldName(string capitalizedName) => capitalizedName != null ? fieldMappings[capitalizedName] : "name";

    #region Helper Classes
    public class CountryInfo {
      public string Name { get; set; }
      public int AreaKM2 { get; set; }
      public int Population { get; set; }
    }

    public class FetchResult {
      public CountryInfo[] Data { get; set; }
      public double[] Summary { get; set; }
    }

    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class SortInfo {
      public string Selector { get; set; }
      public bool Desc { get; set; }
    }

    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class SummaryInfo {
      public string Selector { get; set; }
      public string SummaryType { get; set; }
    }
    #endregion
  }
}
