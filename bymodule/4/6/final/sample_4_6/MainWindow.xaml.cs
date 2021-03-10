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
using DevExpress.Xpf.Gantt;

namespace sample_4_6 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : ThemedWindow {
    public MainWindow() {
      InitializeComponent();
    }

    private void GanttView_Loaded(object sender, RoutedEventArgs e) {
      ((GanttView)sender).ScheduleAll();
    }
  }
}
