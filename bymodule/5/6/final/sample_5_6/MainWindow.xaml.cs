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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.DataSources;

namespace sample_5_6 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow {
    public MainWindow() {
      InitializeComponent();

      var viewModel = DataContext as ViewModel;
      var measurements = viewModel.Measurements;
      surfaceView.Material = CreateGridMaterial(measurements.Impedances, measurements.Phases);
    }

    private void ChartControl_CustomDrawSeriesPoint(object sender, DevExpress.Xpf.Charts.CustomDrawSeriesPointEventArgs e) {
      var countryInfo = e.SeriesPoint.Tag as CountryInfo;
      if (countryInfo != null)
        e.LabelText = countryInfo.Name;
    }

    private void ChartControl_CustomDrawCrosshair(object sender, DevExpress.Xpf.Charts.CustomDrawCrosshairEventArgs e) {
      if (e.CrosshairElementGroups.Count > 0 &&
      e.CrosshairElementGroups[0].CrosshairElements.Count > 0) {
        var element = e.CrosshairElementGroups[0].CrosshairElements[0];
        element.LabelElement.Text = element.SeriesPoint.Tag.ToString();
      }
    }

    static Pen pen = new Pen(new SolidColorBrush(Colors.Red), 2);

    Material CreateGridMaterial(IEnumerable<double> xvalues, IEnumerable<double> yvalues) {
      MaterialGroup materialGroup = new MaterialGroup();

      materialGroup.Children.Add(new DiffuseMaterial(
        new SolidColorBrush(Color.FromArgb(255, 193, 224, 229))));

      var elementBitmap = new RenderTargetBitmap(1000, 1000, 96, 96, PixelFormats.Default);
      var drawingVisual = new DrawingVisual();

      double xoffset = xvalues.Min();
      double xfactor = 1000 / (xvalues.Max() - xoffset);
      double yoffset = yvalues.Min();
      double yfactor = 1000 / (yvalues.Max() - yoffset);

      using (DrawingContext drawingContext = drawingVisual.RenderOpen()) {
        foreach (var xval in xvalues) {
          var x = (xval - xoffset) * xfactor;
          drawingContext.DrawLine(pen, new Point(x, 0), new Point(x, 1000));
        }
        foreach (var yval in yvalues) {
          var y = (yval - yoffset) * yfactor;
          drawingContext.DrawLine(pen, new Point(0, y), new Point(1000, y));
        }
      }
      elementBitmap.Render(drawingVisual);
      materialGroup.Children.Add(new DiffuseMaterial(new ImageBrush(elementBitmap)));

      return materialGroup;
    }
  }
}
